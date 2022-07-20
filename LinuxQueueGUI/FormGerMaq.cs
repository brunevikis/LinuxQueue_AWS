using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinuxQueueGUI
{
    public partial class FormGerMaq : Form
    {
        public FormGerMaq()
        {
            InitializeComponent();

            var linhas = File.ReadAllLines(@"X:\AWS\enercore_ctl_common\config").Skip(1).ToList();
            lv_GerMaq.Items.Clear();

            List<string> demand = new List<string> { "A6", "A7", "B11", "B12","D1","C0" };
            bool b12 = false;
            if (lv_GerMaq.Items.Count == 0)
            {
                foreach (var li in linhas)
                {
                    bool habilitado = true;

                    var dados = li.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    if (dados[0].Contains("#"))
                    {
                        habilitado = false;
                    }
                    string cluster = dados[0].Replace("#", "");


                    string[] partes = new string[3];
                    partes[0] = cluster;
                    partes[1] = cluster.StartsWith("A") ? "NEWAVE" : cluster.StartsWith("B")? "DECOMP" : cluster.StartsWith("D")? "DESSEM": "FILA";
                    partes[2] = demand.Any(x => x.Equals(cluster)) ? "ON_DEMAND" : "SPOT";
                    ListViewItem l = new ListViewItem(partes);
                    l.Checked = habilitado;
                    if (cluster == "B12")
                    {
                        if (b12 == false)
                        {
                            lv_GerMaq.Items.Add(l);
                            b12 = true;
                        }
                    }
                    else if (cluster == "l0" || cluster == "B13" || cluster == "C0")
                    {
                        continue;
                    }
                    else
                    {
                        lv_GerMaq.Items.Add(l);
                    }
                }
                lv_GerMaq.Show();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string configArq = @"X:\AWS\enercore_ctl_common\config";
            string decompViab = @"X:\AWS\enercore_ctl_common\scripts\decomp31Viab.sh";
            var linhas = File.ReadAllLines(configArq).ToList();
            List<string> novaslinhas = new List<string>();
            List<Tuple<string, bool>> estados = new List<Tuple<string, bool>>();


            if (lv_GerMaq.Items.Count > 0)
            {
                foreach (ListViewItem lst in lv_GerMaq.Items)
                {
                    estados.Add(new Tuple<string, bool>(lst.SubItems[0].Text,lst.Checked));
                }
                //string cluster = lst.SubItems[0].Text;
                foreach (var li in linhas)
                {

                    string dummy = li;
                    string cluster = li.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).First().Replace("#", "");

                    foreach (var est in estados)
                    {
                        if (est.Item1.Equals(cluster))
                        {
                            if (est.Item2 == true)
                            {
                                if (est.Item1.Equals("B12"))
                                {
                                    string script = File.ReadAllText(decompViab).Replace("rm -r /mnt/resource/decomp/*", "#rm -r /mnt/resource/decomp/*");
                                    File.WriteAllText(decompViab, script);
                                }
                                dummy = li.Replace("#", "");
                            }
                            else
                            {
                                if (est.Item1.Equals("B12"))
                                {
                                    string script = File.ReadAllText(decompViab).Replace("#rm -r /mnt/resource/decomp/*", "rm -r /mnt/resource/decomp/*");
                                    File.WriteAllText(decompViab, script);
                                }
                                if (!dummy.StartsWith("#"))
                                {
                                    dummy = "#" + dummy;
                                }
                            }
                        }
                    }
                    novaslinhas.Add(dummy);
                }
                File.WriteAllLines(configArq, novaslinhas);

                MessageBox.Show("Alteração Realizada!!!");
            }


        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
