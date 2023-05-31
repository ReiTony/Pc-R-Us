using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class parts_our_us : Form
    {
        // pricing
        // Processors
        const double price_i9_10900k = 31327.00;
        const double price_i7_10700k = 19442.00;
        const double price_i5_10600KF = 11812.00;
        const double price_Ryzen7_5800k = 24716.00;
        const double price_Ryzen7_3700X = 18852.00;
        const double price_Ryzen5_2600 = 11135.00;
        // Motherboards
        const double price_ASRock_B450M = 5074.00;
        const double price_ASRock_B550 = 17485.00;
        const double price_MSI_X570 = 16814.00;
        const double price_GIGABYTE_X570 = 14061.00;
        const double price_GIGABYTE_B450 = 8070.00;
        // Rams
        const double price_GSKILL_16GB = 6480.00;
        const double price_Crucial_32GB = 31814.00;
        const double price_CORSAIR_32GB = 12078.00;
        // HDDS
        const double price_BarraCuda_2TB = 3270.00;
        const double price_IronWolf_8TB = 12078.00;
        const double price_IronWolf_6TB = 9433.00;
        // Cpu Coolers
        const double price_Hyper_212 = 2229.00;
        const double price_CORSAIR_H100i = 6709.00;
        const double price_ML_ML240L = 4168.00;
        // GPUs (Nvidia)
        const double price_RTX_2060 = 48140.00;
        const double price_GTX_1650 = 7500.00;
        const double price_GTX_1660 = 12722.00;
        // GPUs (AMD)
        const double price_Radeon_RX550 = 11879.00;
        const double price_Radeon_RX580 = 16000.00;
        // PSUs
        const double price_CORSAIRVS_600W = 3343.00;
        const double price_EVGA_600W = 3951.00;
        const double price_Thermaltake_650W = 5967.00;
        // SSDs
        const double price_Sabrent_1TB = 8474.00;
        const double price_BarraCuda_1TB = 8836.00;
        const double price_Intel_512GB = 3711.00;

        public parts_our_us()
        {
            InitializeComponent();
        }
        //place order button add all 
        public void total_price()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            total.Text = "php" + Convert.ToString(sum);
        }

        //reset button cancell all numeric  
        private void reset_numeric_up_down()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //reset button cancell all checked box 
        private void reset_check_box()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void pares_retiro_Load(object sender, EventArgs e)
        {
            text_name.Text = "";
            text_address.Text = "";
            text_contact.Text = "";
            text_payment.Text = "";
            text_change.Text = "0";

            box_i9_10900k.Enabled = false;
            box_i9_10900k.Text = "0";

            box_i7_10700k.Enabled = false;
            box_i7_10700k.Text = "0";

            box_i5_10600KF.Enabled = false;
            box_i5_10600KF.Text = "0";

            box_Ryzen7_5800k.Enabled = false;
            box_Ryzen7_5800k.Text = "0";

            box_Ryzen7_3700X.Enabled = false;
            box_Ryzen7_3700X.Text = "0";

            box_Ryzen5_2600.Enabled = false;
            box_Ryzen5_2600.Text = "0";

            box_ASRock_B450M.Enabled = false;
            box_ASRock_B450M.Text = "0";

            box_ASRock_B550.Enabled = false;
            box_ASRock_B550.Text = "0";

            box_MSI_X570.Enabled = false;
            box_MSI_X570.Text = "0";

            box_GIGABYTE_X570.Enabled = false;
            box_GIGABYTE_X570.Text = "0";

            box_GIGABYTE_B450.Enabled = false;
            box_GIGABYTE_B450.Text = "0";

            box_GSKILL_16GB.Enabled = false;
            box_GSKILL_16GB.Text = "0";

            box_Crucial_32GB.Enabled = false;
            box_Crucial_32GB.Text = "0";

            box_CORSAIR_32GB.Enabled = false;
            box_CORSAIR_32GB.Text = "0";

            box_BarraCuda_2TB.Enabled = false;
            box_BarraCuda_2TB.Text = "0";

            box_IronWolf_8TB.Enabled = false;
            box_IronWolf_8TB.Text = "0";

            box_IronWolf_6TB.Enabled = false;
            box_IronWolf_6TB.Text = "0";


            box_Hyper_212.Enabled = false;
            box_Hyper_212.Text = "0";

            box_CORSAIR_H100i.Enabled = false;
            box_CORSAIR_H100i.Text = "0";

            box_ML_ML240L.Enabled = false;
            box_ML_ML240L.Text = "0";

            box_RTX_2060.Enabled = false;
            box_RTX_2060.Text = "0";

            box_GTX_1650.Enabled = false;
            box_GTX_1650.Text = "0";

            box_GTX_1660.Enabled = false;
            box_GTX_1660.Text = "0";

            box_Radeon_RX550.Enabled = false;
            box_Radeon_RX550.Text = "0";

            box_Radeon_RX580.Enabled = false;
            box_Radeon_RX580.Text = "0";

            box_CORSAIRVS_600W.Enabled = false;
            box_CORSAIRVS_600W.Text = "0";

            box_EVGA_600W.Enabled = false;
            box_EVGA_600W.Text = "0";

            box_Thermaltake_650W.Enabled = false;
            box_Thermaltake_650W.Text = "0";

            box_Sabrent_1TB.Enabled = false;
            box_Sabrent_1TB.Text = "0";

            box_BarraCuda_1TB.Enabled = false;
            box_BarraCuda_1TB.Text = "0";

            box_Intel_512GB.Enabled = false;
            box_Intel_512GB.Text = "0";
        }
        private void i9_10900k_CheckedChanged(object sender, EventArgs e)
        {
            if (i9_10900k.Checked == true)
            {
                box_i9_10900k.Enabled = true;
                box_i9_10900k.Text = "1";
                box_i9_10900k.Focus();
            }
            else
            {
                box_i9_10900k.Enabled = false;
                box_i9_10900k.Text = "0";
            }
        }

        private void i7_10700k_CheckedChanged(object sender, EventArgs e)
        {
            if (i7_10700k.Checked == true)
            {
                box_i7_10700k.Enabled = true;
                box_i7_10700k.Text = "1";
                box_i7_10700k.Focus();
            }
            else
            {
                box_i7_10700k.Enabled = false;
                box_i7_10700k.Text = "0";
            }
        }

        private void i5_10600KF_CheckedChanged_1(object sender, EventArgs e)
        {

            if (i5_10600KF.Checked == true)
            {
                box_i5_10600KF.Enabled = true;
                box_i5_10600KF.Text = "1";
                box_i5_10600KF.Focus();
            }
            else
            {
                box_i5_10600KF.Enabled = false;
                box_i5_10600KF.Text = "0";

            }
        }

        private void Ryzen7_5800k_CheckedChanged(object sender, EventArgs e)
        {
            if (Ryzen7_5800k.Checked == true)
            {
                box_Ryzen7_5800k.Enabled = true;
                box_Ryzen7_5800k.Text = "1";
                box_Ryzen7_5800k.Focus();
            }
            else
            {
                box_Ryzen7_5800k.Enabled = false;
                box_Ryzen7_5800k.Text = "0";

            }
        }

        private void Ryzen7_3700X_CheckedChanged(object sender, EventArgs e)
        {
            if (Ryzen7_3700X.Checked == true)
            {
                box_Ryzen7_3700X.Enabled = true;
                box_Ryzen7_3700X.Text = "1";
                box_Ryzen7_3700X.Focus();
            }
            else
            {
                box_Ryzen7_3700X.Enabled = false;
                box_Ryzen7_3700X.Text = "0";

            }
        }

        private void Ryzen5_2600_CheckedChanged(object sender, EventArgs e)
        {
            if (Ryzen5_2600.Checked == true)
            {
                box_Ryzen5_2600.Enabled = true;
                box_Ryzen5_2600.Text = "1";
                box_Ryzen5_2600.Focus();
            }
            else
            {
                box_Ryzen5_2600.Enabled = false;
                box_Ryzen5_2600.Text = "0";

            }
        }

        private void ASRock_B450M_CheckedChanged(object sender, EventArgs e)
        {
            if (ASRock_B450M.Checked == true)
            {
                box_ASRock_B450M.Enabled = true;
                box_ASRock_B450M.Text = "1";
                box_ASRock_B450M.Focus();
            }
            else
            {
                box_ASRock_B450M.Enabled = false;
                box_ASRock_B450M.Text = "0";
            }

        }

        private void ASRock_B550_CheckedChanged(object sender, EventArgs e)
        {
            if (ASRock_B550.Checked == true)
            {
                box_ASRock_B550.Enabled = true;
                box_ASRock_B550.Text = "1";
                box_ASRock_B550.Focus();
            }
            else
            {
                box_ASRock_B550.Enabled = false;
                box_ASRock_B550.Text = "0";
            }
        }

        private void MSI_X570_CheckedChanged(object sender, EventArgs e)
        {
            if (MSI_X570.Checked == true)
            {
                box_MSI_X570.Enabled = true;
                box_MSI_X570.Text = "1";
                box_MSI_X570.Focus();
            }
            else
            {
                box_MSI_X570.Enabled = false;
                box_MSI_X570.Text = "0";
            }
        }

        private void GIGABYTE_X570_CheckedChanged(object sender, EventArgs e)
        {
            if (GIGABYTE_X570.Checked == true)
            {
                box_GIGABYTE_X570.Enabled = true;
                box_GIGABYTE_X570.Text = "1";
                box_GIGABYTE_X570.Focus();
            }
            else
            {
                box_GIGABYTE_X570.Enabled = false;
                box_GIGABYTE_X570.Text = "0";
            }
        }

        private void GIGABYTE_B450_CheckedChanged(object sender, EventArgs e)
        {
            if (GIGABYTE_B450.Checked == true)
            {
                box_GIGABYTE_B450.Enabled = true;
                box_GIGABYTE_B450.Text = "1";
                box_GIGABYTE_B450.Focus();
            }
            else
            {
                box_GIGABYTE_B450.Enabled = false;
                box_GIGABYTE_B450.Text = "0";
            }
        }

        private void GSKILL_16GB_CheckedChanged(object sender, EventArgs e)
        {
            if (GSKILL_16GB.Checked == true)
            {
                box_GSKILL_16GB.Enabled = true;
                box_GSKILL_16GB.Text = "1";
                box_GSKILL_16GB.Focus();
            }
            else
            {
                box_GSKILL_16GB.Enabled = false;
                box_GSKILL_16GB.Text = "0";
            }
        }

        private void Crucial_32GB_CheckedChanged(object sender, EventArgs e)
        {
            if (Crucial_32GB.Checked == true)
            {
                box_Crucial_32GB.Enabled = true;
                box_Crucial_32GB.Text = "1";
                box_Crucial_32GB.Focus();
            }
            else
            {
                box_Crucial_32GB.Enabled = false;
                box_Crucial_32GB.Text = "0";
            }
        }

        private void CORSAIR_32GB_CheckedChanged(object sender, EventArgs e)
        {
            if (CORSAIR_32GB.Checked == true)
            {
                box_CORSAIR_32GB.Enabled = true;
                box_CORSAIR_32GB.Text = "1";
                box_CORSAIR_32GB.Focus();
            }
            else
            {
                box_CORSAIR_32GB.Enabled = false;
                box_CORSAIR_32GB.Text = "0";
            }
        }

        private void BarraCuda_2TB_CheckedChanged(object sender, EventArgs e)
        {
            if (BarraCuda_2TB.Checked == true)
            {
                box_BarraCuda_2TB.Enabled = true;
                box_BarraCuda_2TB.Text = "1";
                box_BarraCuda_2TB.Focus();
            }
            else
            {
                box_BarraCuda_2TB.Enabled = false;
                box_BarraCuda_2TB.Text = "0";
            }
        }

        private void IronWolf_8TB_CheckedChanged(object sender, EventArgs e)
        {
            if (IronWolf_8TB.Checked == true)
            {
                box_IronWolf_8TB.Enabled = true;
                box_IronWolf_8TB.Text = "1";
                box_IronWolf_8TB.Focus();
            }
            else
            {
                box_IronWolf_8TB.Enabled = false;
                box_IronWolf_8TB.Text = "0";
            }
        }

        private void IronWolf_6TB_CheckedChanged(object sender, EventArgs e)
        {
            if (IronWolf_6TB.Checked == true)
            {
                box_IronWolf_6TB.Enabled = true;
                box_IronWolf_6TB.Text = "1";
                box_IronWolf_6TB.Focus();
            }
            else
            {
                box_IronWolf_6TB.Enabled = false;
                box_IronWolf_6TB.Text = "0";
            }
        }

        private void Hyper_212_CheckedChanged(object sender, EventArgs e)
        {
            if (Hyper_212.Checked == true)
            {
                box_Hyper_212.Enabled = true;
                box_Hyper_212.Text = "1";
                box_Hyper_212.Focus();
            }
            else
            {
                box_Hyper_212.Enabled = false;
                box_Hyper_212.Text = "0";
            }
        }
       
        private void CORSAIR_H100i_CheckedChanged(object sender, EventArgs e)
        {
            if (CORSAIR_H100i.Checked == true)
            {
                box_CORSAIR_H100i.Enabled = true;
                box_CORSAIR_H100i.Text = "1";
                box_CORSAIR_H100i.Focus();
            }
            else
            {
                box_CORSAIR_H100i.Enabled = false;
                box_CORSAIR_H100i.Text = "0";
            }
        }

        private void ML_ML240L_CheckedChanged(object sender, EventArgs e)
        {
            if (ML_ML240L.Checked == true)
            {
                box_ML_ML240L.Enabled = true;
                box_ML_ML240L.Text = "1";
                box_ML_ML240L.Focus();
            }
            else
            {
                box_ML_ML240L.Enabled = false;
                box_ML_ML240L.Text = "0";
            }
        }

        private void RTX_2060_CheckedChanged(object sender, EventArgs e)
        {
            if (RTX_2060.Checked == true)
            {
                box_RTX_2060.Enabled = true;
                box_RTX_2060.Text = "1";
                box_RTX_2060.Focus();
            }
            else
            {
                box_RTX_2060.Enabled = false;
                box_RTX_2060.Text = "0";
            }
        }

        private void GTX_1650_CheckedChanged(object sender, EventArgs e)
        {
            if (GTX_1650.Checked == true)
            {
                box_GTX_1650.Enabled = true;
                box_GTX_1650.Text = "1";
                box_GTX_1650.Focus();
            }
            else
            {
                box_GTX_1650.Enabled = false;
                box_GTX_1650.Text = "0";
            }
        }

        private void GTX_1660_CheckedChanged(object sender, EventArgs e)
        {
            if (GTX_1660.Checked == true)
            {
                box_GTX_1660.Enabled = true;
                box_GTX_1660.Text = "1";
                box_GTX_1660.Focus();
            }
            else
            {
                box_GTX_1660.Enabled = false;
                box_GTX_1660.Text = "0";
            }
        }

        private void Radeon_RX550_CheckedChanged(object sender, EventArgs e)
        {
            if (Radeon_RX550.Checked == true)
            {
                box_Radeon_RX550.Enabled = true;
                box_Radeon_RX550.Text = "1";
                box_Radeon_RX550.Focus();
            }
            else
            {
                box_Radeon_RX550.Enabled = false;
                box_Radeon_RX550.Text = "0";
            }
        }

        private void Radeon_RX580_CheckedChanged(object sender, EventArgs e)
        {
            if (Radeon_RX580.Checked == true)
            {
                box_Radeon_RX580.Enabled = true;
                box_Radeon_RX580.Text = "1";
                box_Radeon_RX580.Focus();
            }
            else
            {
                box_Radeon_RX580.Enabled = false;
                box_Radeon_RX580.Text = "0";
            }
        }

        private void CORSAIRVS_600W_CheckedChanged(object sender, EventArgs e)
        {
            if (CORSAIRVS_600W.Checked == true)
            {
                box_CORSAIRVS_600W.Enabled = true;
                box_CORSAIRVS_600W.Text = "1";
                box_CORSAIRVS_600W.Focus();
            }
            else
            {
                box_CORSAIRVS_600W.Enabled = false;
                box_CORSAIRVS_600W.Text = "0";
            }
        }

        private void EVGA_600W_CheckedChanged(object sender, EventArgs e)
        {
            if (EVGA_600W.Checked == true)
            {
                box_EVGA_600W.Enabled = true;
                box_EVGA_600W.Text = "1";
                box_EVGA_600W.Focus();
            }
            else
            {
                box_EVGA_600W.Enabled = false;
                box_EVGA_600W.Text = "0";
            }
        }

        private void Thermaltake_650W_CheckedChanged(object sender, EventArgs e)
        {
            if (Thermaltake_650W.Checked == true)
            {
                box_Thermaltake_650W.Enabled = true;
                box_Thermaltake_650W.Text = "1";
                box_Thermaltake_650W.Focus();
            }
            else
            {
                box_Thermaltake_650W.Enabled = false;
                box_Thermaltake_650W.Text = "0";
            }
        }

        private void Sabrent_1TB_CheckedChanged(object sender, EventArgs e)
        {
            if (Sabrent_1TB.Checked == true)
            {
                box_Sabrent_1TB.Enabled = true;
                box_Sabrent_1TB.Text = "1";
                box_Sabrent_1TB.Focus();
            }
            else
            {
                box_Sabrent_1TB.Enabled = false;
                box_Sabrent_1TB.Text = "0";
            }
        }

        private void BarraCuda_1TB_CheckedChanged(object sender, EventArgs e)
        {
            if (BarraCuda_1TB.Checked == true)
            {
                box_BarraCuda_1TB.Enabled = true;
                box_BarraCuda_1TB.Text = "1";
                box_BarraCuda_1TB.Focus();
            }
            else
            {
                box_BarraCuda_1TB.Enabled = false;
                box_BarraCuda_1TB.Text = "0";
            }
        }

        private void Intel_512GB_CheckedChanged(object sender, EventArgs e)
        {
            if (Intel_512GB.Checked == true)
            {
                box_Intel_512GB.Enabled = true;
                box_Intel_512GB.Text = "1";
                box_Intel_512GB.Focus();
            }
            else
            {
                box_Intel_512GB.Enabled = false;
                box_Intel_512GB.Text = "0";
            }
        }
        
        private void back_button_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
            item.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult exit_button;
            exit_button = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit_button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // clear rows form dataGridView
            dataGridView1.Refresh(); // refresh dataGridView
            reset_numeric_up_down();
            reset_check_box();

            
            total.Text = "0";

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            DateTime iDate = DateTime.Now;
            //name.Text = iDate.ToString("MM/dd/yyyy");
            //contact.Text = iDate.ToString("HH:mm:ss");

          

            text_receipt.Clear();

            tabControl1.SelectedTab = tabPage2;
            text_receipt.AppendText("\t\t\t" + "Pc-R-Us" + Environment.NewLine);
            text_receipt.AppendText("===========================================================" + Environment.NewLine);
            text_receipt.AppendText(" " + Environment.NewLine);

            text_receipt.AppendText("Name: " + text_name.Text + "\t\t" + "Contact Number: " + text_contact.Text + Environment.NewLine);
            //text_receipt.AppendText("Contact Number: " + contact.Text);
            text_receipt.AppendText("Address: " + text_address.Text + Environment.NewLine);
            text_receipt.AppendText("Order Date: " + iDate.ToString("MM/dd/yyyy") + "\t\t" + "Order Time:" + iDate.ToString("HH:mm:ss") + Environment.NewLine);
            text_receipt.AppendText(Environment.NewLine + "===========================================================" + Environment.NewLine);
            text_receipt.AppendText("QTY" + " \t\t" + "ITEM" + "\t\t\t" + "PRICE" + Environment.NewLine);

            if (i9_10900k.Checked == true)
            {
                text_receipt.AppendText(box_i9_10900k.Value + "\t\t" + "Core i9-10900k" + "\t\t" + box_i9_10900k.Value * 31327 + Environment.NewLine);
            }
            if (i7_10700k.Checked == true)
            {
                text_receipt.AppendText(box_i7_10700k.Value + "\t\t" + "Core i7-10700k" + "\t\t" + box_i7_10700k.Value * 19442 + Environment.NewLine);
            }
            if (i5_10600KF.Checked == true)
            {
                text_receipt.AppendText(box_i5_10600KF.Value + "\t\t" + "Core i5-10600KF" + "\t\t" + box_i5_10600KF.Value * 11812 + Environment.NewLine);
            }
            if (Ryzen7_5800k.Checked == true)
            {
                text_receipt.AppendText(box_Ryzen7_5800k.Value + "\t\t" + "Ryzen 7 5800K" + "\t\t" + box_Ryzen7_5800k.Value * 24716 + Environment.NewLine);
            }
            if (Ryzen7_3700X.Checked == true)
            {
                text_receipt.AppendText(box_Ryzen7_3700X.Value + "\t\t" + "Ryzen 7 3700X" + "\t\t" + box_Ryzen7_3700X.Value * 18852 + Environment.NewLine);
            }
            if (Ryzen5_2600.Checked == true)
            {
                text_receipt.AppendText(box_Ryzen5_2600.Value + "\t\t" + "Ryzen 5 2600" + "\t\t" + box_Ryzen5_2600.Value * 11135 + Environment.NewLine);
            }
            if (ASRock_B450M.Checked == true)
            {

                text_receipt.AppendText(box_ASRock_B450M.Value + "\t\t" + "ASRock B450M" + "\t\t" + box_ASRock_B450M.Value * 5074 + Environment.NewLine);
            }
            if (ASRock_B550.Checked == true)
            {

                text_receipt.AppendText(box_ASRock_B550.Value + "\t\t" + "ASRock B550" + "\t\t" + box_ASRock_B550.Value * 17485 + Environment.NewLine);
            }
            if (MSI_X570.Checked == true)
            {

                text_receipt.AppendText(box_MSI_X570.Value + "\t\t" + "MSI X570" + "\t\t\t" + box_MSI_X570.Value * 16814 + Environment.NewLine);
            }
            if (GIGABYTE_X570.Checked == true)
            {

                text_receipt.AppendText(box_GIGABYTE_X570.Value + "\t\t" + "GIGABYTE X570" + "\t\t" + box_GIGABYTE_X570.Value * 14061 + Environment.NewLine);
            }
            if (GIGABYTE_B450.Checked == true)
            {

                text_receipt.AppendText(box_GIGABYTE_B450.Value + "\t\t" + "GIGABYTE B450" + "\t\t" + box_GIGABYTE_B450.Value * 8070 + Environment.NewLine);
            }
            if (GSKILL_16GB.Checked == true)
            {

                text_receipt.AppendText(box_GSKILL_16GB.Value + "\t\t" + "Trident 16GB" + "\t\t" + box_GSKILL_16GB.Value * 6480 + Environment.NewLine);
            }
            if (Crucial_32GB.Checked == true)
            {

                text_receipt.AppendText(box_Crucial_32GB.Value + "\t\t" + "Ballistix 32GB" + "\t\t" + box_Crucial_32GB.Value * 31814 + Environment.NewLine);
            }
            if (CORSAIR_32GB.Checked == true)
            {

                text_receipt.AppendText(box_CORSAIR_32GB.Value + "\t\t" + "Vengeance 32GB" + "\t\t" + box_CORSAIR_32GB.Value * 12078 + Environment.NewLine);
            }
            if (BarraCuda_2TB.Checked == true)
            {

                text_receipt.AppendText(box_BarraCuda_2TB.Value + "\t\t" + "BarraCuda 2TB" + "\t\t" + box_BarraCuda_2TB.Value * 3270 + Environment.NewLine);
            }
            if (IronWolf_8TB.Checked == true)
            {

                text_receipt.AppendText(box_IronWolf_8TB.Value + "\t\t" + "IronWolf 8TB" + "\t\t" + box_IronWolf_8TB.Value * 12078 + Environment.NewLine);
            }
            if (IronWolf_6TB.Checked == true)
            {

                text_receipt.AppendText(box_IronWolf_6TB.Value + "\t\t" + "IronWolf 6TB" + "\t\t" + box_IronWolf_6TB.Value * 9433 + Environment.NewLine);
            }
            if (Hyper_212.Checked == true)
            {

                text_receipt.AppendText(box_Hyper_212.Value + "\t\t" + "Hyper 212" + "\t\t" + box_Hyper_212.Value * 2229 + Environment.NewLine);
            }
            if (CORSAIR_H100i.Checked == true)
            {

                text_receipt.AppendText(box_CORSAIR_H100i.Value + "\t\t" + "CORSAIR H100i" + "\t\t" + box_CORSAIR_H100i.Value * 6709 + Environment.NewLine);
            }
            if (ML_ML240L.Checked == true)
            {

                text_receipt.AppendText(box_ML_ML240L.Value + "\t\t" + "ML ML240L" + "\t\t" + box_ML_ML240L.Value * 4168 + Environment.NewLine);
            }
            if (RTX_2060.Checked == true)
            {

                text_receipt.AppendText(box_RTX_2060.Value + "\t\t" + "RTX 2060" + "\t\t" + box_RTX_2060.Value * 48140 + Environment.NewLine);
            }
            if (GTX_1650.Checked == true)
            {

                text_receipt.AppendText(box_GTX_1650.Value + "\t\t" + "GTX 1650" + "\t\t" + box_GTX_1650.Value * 7500 + Environment.NewLine);
            }
            if (GTX_1660.Checked == true)
            {

                text_receipt.AppendText(box_GTX_1660.Value + "\t\t" + "GTX 1660" + "\t\t" + box_GTX_1660.Value * 12722 + Environment.NewLine);
            }
            if (Radeon_RX550.Checked == true)
            {

                text_receipt.AppendText(box_Radeon_RX550.Value + "\t\t" + "Radeon RX550" + "\t\t" + box_Radeon_RX550.Value * 11879 + Environment.NewLine);
            }
            if (Radeon_RX580.Checked == true)
            {

                text_receipt.AppendText(box_Radeon_RX580.Value + "\t\t" + "Radeon RX580" + "\t\t" + box_Radeon_RX580.Value * 16000 + Environment.NewLine);
            }
            if (CORSAIRVS_600W.Checked == true)
            {

                text_receipt.AppendText(box_CORSAIRVS_600W.Value + "\t\t" + "CORSAIR VS 600W" + "\t" + box_CORSAIRVS_600W.Value * 3343 + Environment.NewLine);
            }
            if (EVGA_600W.Checked == true)
            {

                text_receipt.AppendText(box_EVGA_600W.Value + "\t\t" + "EVGA 600W" + "\t\t" + box_EVGA_600W.Value * 3951 + Environment.NewLine);
            }
            if (Thermaltake_650W.Checked == true)
            {

                text_receipt.AppendText(box_Thermaltake_650W.Value + "\t\t" + "Thermaltake 650W" + "\t\t" + box_Thermaltake_650W.Value * 5967 + Environment.NewLine);
            }
            if (Sabrent_1TB.Checked == true)
            {

                text_receipt.AppendText(box_Sabrent_1TB.Value + "\t\t" + "Sabrent 1TB" + "\t\t" + box_Sabrent_1TB.Value * 8474 + Environment.NewLine);
            }
            if (BarraCuda_1TB.Checked == true)
            {

                text_receipt.AppendText(box_BarraCuda_1TB.Value + "\t\t" + "BarraCuda SSD 1TB" + "\t" + box_BarraCuda_1TB.Value * 8836 + Environment.NewLine);
            }
            if (Intel_512GB.Checked == true)
            {

                text_receipt.AppendText(box_Intel_512GB.Value + "\t\t" + "Intel 660p 512GB" + "\t\t" + box_Intel_512GB.Value * 3711 + Environment.NewLine);
            }
            text_receipt.AppendText(Environment.NewLine + "===========================================================" + Environment.NewLine);
           
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToInt32(box_i9_10900k.Value) * price_i9_10900k;
            itemcost[1] = Convert.ToInt32(box_i7_10700k.Value) * price_i7_10700k;
            itemcost[2] = Convert.ToInt32(box_i5_10600KF.Value) * price_i5_10600KF;
            itemcost[3] = Convert.ToInt32(box_Ryzen7_5800k.Value) * price_Ryzen7_5800k;
            itemcost[4] = Convert.ToInt32(box_Ryzen7_3700X.Value) * price_Ryzen7_3700X;
            itemcost[5] = Convert.ToInt32(box_Ryzen5_2600.Value) * price_Ryzen5_2600;
            itemcost[6] = Convert.ToInt32(box_ASRock_B450M.Value) * price_ASRock_B450M;
            itemcost[7] = Convert.ToInt32(box_ASRock_B550.Value) * price_ASRock_B550;
            itemcost[8] = Convert.ToInt32(box_MSI_X570.Value) * price_MSI_X570;
            itemcost[9] = Convert.ToInt32(box_GIGABYTE_X570.Value) * price_GIGABYTE_X570;
            itemcost[10] = Convert.ToInt32(box_GIGABYTE_B450.Value) * price_GIGABYTE_B450;
            itemcost[11] = Convert.ToInt32(box_GSKILL_16GB.Value) * price_GSKILL_16GB;
            itemcost[12] = Convert.ToInt32(box_Crucial_32GB.Value) * price_Crucial_32GB;
            itemcost[13] = Convert.ToInt32(box_CORSAIR_32GB.Value) * price_CORSAIR_32GB;
            itemcost[14] = Convert.ToInt32(box_BarraCuda_2TB.Value) * price_BarraCuda_2TB;
            itemcost[15] = Convert.ToInt32(box_IronWolf_8TB.Value) * price_IronWolf_8TB;
            itemcost[16] = Convert.ToInt32(box_IronWolf_6TB.Value) * price_IronWolf_6TB;
            itemcost[17] = Convert.ToInt32(box_Hyper_212.Value) * price_Hyper_212;
            itemcost[18] = Convert.ToInt32(box_CORSAIR_H100i.Value) * price_CORSAIR_H100i;
            itemcost[19] = Convert.ToInt32(box_ML_ML240L.Value) * price_ML_ML240L;
            itemcost[20] = Convert.ToInt32(box_RTX_2060.Value) * price_RTX_2060;
            itemcost[21] = Convert.ToInt32(box_GTX_1650.Value) * price_GTX_1650;
            itemcost[22] = Convert.ToInt32(box_GTX_1660.Value) * price_GTX_1660;
            itemcost[23] = Convert.ToInt32(box_Radeon_RX550.Value) * price_Radeon_RX550;
            itemcost[24] = Convert.ToInt32(box_Radeon_RX580.Value) * price_Radeon_RX580;
            itemcost[25] = Convert.ToInt32(box_CORSAIRVS_600W.Value) * price_CORSAIRVS_600W;
            itemcost[26] = Convert.ToInt32(box_EVGA_600W.Value) * price_EVGA_600W;
            itemcost[27] = Convert.ToInt32(box_Thermaltake_650W.Value) * price_Thermaltake_650W;
            itemcost[28] = Convert.ToInt32(box_Sabrent_1TB.Value) * price_Sabrent_1TB;
            itemcost[29] = Convert.ToInt32(box_BarraCuda_1TB.Value) * price_BarraCuda_1TB;
            itemcost[30] = Convert.ToInt32(box_Intel_512GB.Value) * price_Intel_512GB;
            

            double total, payment, change, vat;
            payment = 0;
            total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + 
                itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22] + itemcost[23] + itemcost[24]
                + itemcost[25] + itemcost[26] + itemcost[27] + itemcost[28] + itemcost[29] + itemcost[30];

            payment = double.Parse(text_payment.Text);
            change = payment - total;
            vat = total * 0.12;
            text_change.Text = Convert.ToString(change);


            if (text_name.Text == "" || text_address.Text == "" || text_contact.Text == "" || text_payment.Text == "0")
            {
                MessageBox.Show("Please complete the information", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
            

            text_receipt.AppendText("\t\t" + "TOTAL:" + "\t\t\t" + total + Environment.NewLine);
            text_receipt.AppendText("\t\t" + "12% VAT:" + "\t\t\t" + vat + Environment.NewLine);
            text_receipt.AppendText("\t\t" + "Cash:" + "\t\t\t" + text_payment.Text + Environment.NewLine);
            text_receipt.AppendText("\t\t" + "Change:" + "\t\t\t" + change + Environment.NewLine);

            

        }

        private void order_button_Click(object sender, EventArgs e)
        {
            

            tabControl1.SelectedTab = tabPage1;

            if ((i9_10900k.Checked == false) && (i7_10700k.Checked == false) && (ASRock_B450M.Checked == false) && (ASRock_B550.Checked == false) && (MSI_X570.Checked == false) && (GIGABYTE_X570.Checked == false) && (GIGABYTE_B450.Checked == false) && (GSKILL_16GB.Checked == false) && (Crucial_32GB.Checked == false) && (CORSAIR_32GB.Checked == false) && (BarraCuda_2TB.Checked == false) && (IronWolf_8TB.Checked == false) && (IronWolf_6TB.Checked == false) && (Hyper_212.Checked == false) && (CORSAIR_H100i.Checked == false) && (ML_ML240L.Checked == false) && (RTX_2060.Checked == false) && (GTX_1650.Checked == false) && (GTX_1660.Checked == false) && (Radeon_RX550.Checked == false) && (Radeon_RX580.Checked == false) && (CORSAIRVS_600W.Checked == false) && (EVGA_600W.Checked == false) && (Thermaltake_650W.Checked == false) && (Sabrent_1TB.Checked == false) && (BarraCuda_1TB.Checked == false) && (Intel_512GB.Checked == false))
            {
                MessageBox.Show("Please select an item", "Item", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            if (i9_10900k.Checked == true)
            {
                double price;
                double qty_i9_10900k = (double)box_i9_10900k.Value;

                price = price_i9_10900k * qty_i9_10900k;
                dataGridView1.Rows.Add(qty_i9_10900k, "Core i9-10900k", price);
            }
            if (i7_10700k.Checked == true)
            {
                double price;
                double qty_i7_10700k = (double)box_i7_10700k.Value;

                price = price_i7_10700k * qty_i7_10700k;
                dataGridView1.Rows.Add(qty_i7_10700k, "Core i7-10700k", price);
            }
            if (i5_10600KF.Checked == true)
            {
                double price;
                double qty_i5_10600KF = (double)box_i5_10600KF.Value;

                price = price_i5_10600KF * qty_i5_10600KF;
                dataGridView1.Rows.Add(qty_i5_10600KF, "Core i5_10600KF", price);
            }
            if (Ryzen7_5800k.Checked == true)
            {
                double price;
                double qty_Ryzen7_5800k = (double)box_Ryzen7_5800k.Value;

                price = price_Ryzen7_5800k * qty_Ryzen7_5800k;
                dataGridView1.Rows.Add(qty_Ryzen7_5800k, "Ryzen 7 5800K", price);
            }
            if (Ryzen7_3700X.Checked == true)
            {
                double price;
                double qty_Ryzen7_3700X = (double)box_Ryzen7_3700X.Value;

                price = price_Ryzen7_3700X * qty_Ryzen7_3700X;
                dataGridView1.Rows.Add(qty_Ryzen7_3700X, "Ryzen 7 3700X", price);
            }
            if (Ryzen5_2600.Checked == true)
            {
                double price;
                double qty_Ryzen5_2600 = (double)box_Ryzen5_2600.Value;

                price = price_Ryzen5_2600 * qty_Ryzen5_2600;
                dataGridView1.Rows.Add(qty_Ryzen5_2600, "Ryzen 5 2600", price);
            }
            if (ASRock_B450M.Checked == true)
            {
                double price;
                double qty_ASRock_B450M = (double)box_ASRock_B450M.Value;

                price = price_ASRock_B450M * qty_ASRock_B450M;
                dataGridView1.Rows.Add(qty_ASRock_B450M, "ASRock B450M", price);
            }
            if (ASRock_B550.Checked == true)
            {
                double price;
                double qty_ASRock_B550 = (double)box_ASRock_B550.Value;

                price = price_ASRock_B550 * qty_ASRock_B550;
                dataGridView1.Rows.Add(qty_ASRock_B550, "ASRock B550", price);
            }
            if (MSI_X570.Checked == true)
            {
                double price;
                double qty_MSI_X570 = (double)box_MSI_X570.Value;

                price = price_MSI_X570 * qty_MSI_X570;
                dataGridView1.Rows.Add(qty_MSI_X570, "MSI MPG X570", price);
            }
            if (GIGABYTE_X570.Checked == true)
            {
                double price;
                double qty_GIGABYTE_X570 = (double)box_GIGABYTE_X570.Value;

                price = price_GIGABYTE_X570 * qty_GIGABYTE_X570;
                dataGridView1.Rows.Add(qty_GIGABYTE_X570, "GIGABYTE X570", price);
            }
            if (GIGABYTE_B450.Checked == true)
            {
                double price;
                double qty_GIGABYTE_B450 = (double)box_GIGABYTE_B450.Value;

                price = price_GIGABYTE_B450 * qty_GIGABYTE_B450;
                dataGridView1.Rows.Add(qty_GIGABYTE_B450, "GIGABYTE B450", price);
            }
            if (GSKILL_16GB.Checked == true)
            {
                double price;
                double qty_GSKILL_16GB = (double)box_GSKILL_16GB.Value;

                price = price_GSKILL_16GB * qty_GSKILL_16GB;
                dataGridView1.Rows.Add(qty_GSKILL_16GB, "Trident 16GB", price);
            }
            if (Crucial_32GB.Checked == true)
            {
                double price;
                double qty_Crucial_32GB = (double)box_Crucial_32GB.Value;

                price = price_Crucial_32GB * qty_Crucial_32GB;
                dataGridView1.Rows.Add(qty_Crucial_32GB, "Ballistix 32GB", price);
            }
            if (CORSAIR_32GB.Checked == true)
            {
                double price;
                double qty_CORSAIR_32GB = (double)box_CORSAIR_32GB.Value;

                price = price_CORSAIR_32GB * qty_CORSAIR_32GB;
                dataGridView1.Rows.Add(qty_CORSAIR_32GB, "Vengeance 32GB", price);
            }
            if (BarraCuda_2TB.Checked == true)
            {
                double price;
                double qty_BarraCuda_2TB = (double)box_BarraCuda_2TB.Value;

                price = price_BarraCuda_2TB * qty_BarraCuda_2TB;
                dataGridView1.Rows.Add(qty_BarraCuda_2TB, "BarraCuda 2TB", price);
            }
            if (IronWolf_8TB.Checked == true)
            {
                double price;
                double qty_IronWolf_8TB = (double)box_IronWolf_8TB.Value;

                price = price_IronWolf_8TB * qty_IronWolf_8TB;
                dataGridView1.Rows.Add(qty_IronWolf_8TB, "IronWolf 8TB", price);
            }
            if (IronWolf_6TB.Checked == true)
            {
                double price;
                double qty_IronWolf_6TB = (double)box_IronWolf_6TB.Value;

                price = price_IronWolf_6TB * qty_IronWolf_6TB;
                dataGridView1.Rows.Add(qty_IronWolf_6TB, "IronWolf 6TB", price);
            }
            if (Hyper_212.Checked == true)
            {
                double price;
                double qty_Hyper_212 = (double)box_Hyper_212.Value;

                price = price_Hyper_212 * qty_Hyper_212;
                dataGridView1.Rows.Add(qty_Hyper_212, "Hyper 212", price);
            }
            if (CORSAIR_H100i.Checked == true)
            {
                double price;
                double qty_CORSAIR_H100i = (double)box_CORSAIR_H100i.Value;

                price = price_CORSAIR_H100i * qty_CORSAIR_H100i;
                dataGridView1.Rows.Add(qty_CORSAIR_H100i, "CORSAIR H100i", price);
            }
            if (ML_ML240L.Checked == true)
            {
                double price;
                double qty_ML_ML240L = (double)box_ML_ML240L.Value;

                price = price_ML_ML240L * qty_ML_ML240L;
                dataGridView1.Rows.Add(qty_ML_ML240L, "ML ML240L", price);
            }
            if (RTX_2060.Checked == true)
            {
                double price;
                double qty_RTX_2060 = (double)box_RTX_2060.Value;

                price = price_RTX_2060 * qty_RTX_2060;
                dataGridView1.Rows.Add(qty_RTX_2060, "RTX 2060", price);
            }
            if (GTX_1650.Checked == true)
            {
                double price;
                double qty_GTX_1650 = (double)box_GTX_1650.Value;

                price = price_GTX_1650 * qty_GTX_1650;
                dataGridView1.Rows.Add(qty_GTX_1650, "GTX 1650", price);
            }
            if (GTX_1660.Checked == true)
            {
                double price;
                double qty_GTX_1660 = (double)box_GTX_1660.Value;

                price = price_GTX_1660 * qty_GTX_1660;
                dataGridView1.Rows.Add(qty_GTX_1660, "GTX 1660", price);
            }
            if (Radeon_RX550.Checked == true)
            {
                double price;
                double qty_Radeon_RX550 = (double)box_Radeon_RX550.Value;

                price = price_Radeon_RX550 * qty_Radeon_RX550;
                dataGridView1.Rows.Add(qty_Radeon_RX550, "Radeon RX550", price);
            }
            if (Radeon_RX580.Checked == true)
            {
                double price;
                double qty_Radeon_RX580 = (double)box_Radeon_RX580.Value;

                price = price_Radeon_RX580 * qty_Radeon_RX580;
                dataGridView1.Rows.Add(qty_Radeon_RX580, "Radeon RX580", price);
            }
            if (CORSAIRVS_600W.Checked == true)
            {
                double price;
                double qty_CORSAIRVS_600W = (double)box_CORSAIRVS_600W.Value;

                price = price_CORSAIRVS_600W * qty_CORSAIRVS_600W;
                dataGridView1.Rows.Add(qty_CORSAIRVS_600W, "CORSAIR VS 600W", price);
            }
            if (EVGA_600W.Checked == true)
            {
                double price;
                double qty_EVGA_600W = (double)box_EVGA_600W.Value;

                price = price_EVGA_600W * qty_EVGA_600W;
                dataGridView1.Rows.Add(qty_EVGA_600W, "EVGA 600W BA", price);
            }
            if (Thermaltake_650W.Checked == true)
            {
                double price;
                double qty_Thermaltake_650W = (double)box_Thermaltake_650W.Value;

                price = price_Thermaltake_650W * qty_Thermaltake_650W;
                dataGridView1.Rows.Add(qty_Thermaltake_650W, "Thermaltake 650W", price);
            }
            if (Sabrent_1TB.Checked == true)
            {
                double price;
                double qty_Sabrent_1TB = (double)box_Sabrent_1TB.Value;

                price = price_Sabrent_1TB * qty_Sabrent_1TB;
                dataGridView1.Rows.Add(qty_Sabrent_1TB, "Sabrent 1TB", price);
            }
            if (BarraCuda_1TB.Checked == true)
            {
                double price;
                double qty_BarraCuda_1TB = (double)box_BarraCuda_1TB.Value;

                price = price_BarraCuda_1TB * qty_BarraCuda_1TB;
                dataGridView1.Rows.Add(qty_BarraCuda_1TB, "BarraCuda SSD 1TB", price);
            }
            if (Intel_512GB.Checked == true)
            {
                double price;
                double qty_Intel_512GB = (double)box_Intel_512GB.Value;

                price = price_Intel_512GB * qty_Intel_512GB;
                dataGridView1.Rows.Add(qty_Intel_512GB, "Intel 660p 512GB", price);
            }



            total_price();
        }

        private void box_i9_10900k_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (cname == "Delete")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                total_price();
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void text_receipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void text_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_change_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void box_IronWolf_6TB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void text_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
