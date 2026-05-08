using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUZ_OOP_CPE201
{
    public partial class POS_Admin : Form
    {   
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private Image pic;
        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\Ken Cruz\\Downloads\\default image.jpg");
                picpathTxtbox1.Clear();
                picpathTxtbox2.Clear();
                picpathTxtbox3.Clear();
                picpathTxtbox4.Clear();
                picpathTxtbox5.Clear();
                picpathTxtbox6.Clear();
                picpathTxtbox7.Clear();
                picpathTxtbox8.Clear();
                picpathTxtbox9.Clear();
                picpathTxtbox10.Clear();
                picpathTxtbox11.Clear();
                picpathTxtbox12.Clear();
                picpathTxtbox13.Clear();
                picpathTxtbox14.Clear();
                picpathTxtbox15.Clear();
                picpathTxtbox16.Clear();
                picpathTxtbox17.Clear();
                picpathTxtbox18.Clear();
                picpathTxtbox19.Clear();
                picpathTxtbox20.Clear();
                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                pictureBox3.Image = pic;
                pictureBox4.Image = pic;
                pictureBox5.Image = pic;
                pictureBox6.Image = pic;
                pictureBox7.Image = pic;
                pictureBox8.Image = pic;
                pictureBox9.Image = pic;
                pictureBox10.Image = pic;
                pictureBox11.Image = pic;
                pictureBox12.Image = pic;
                pictureBox13.Image = pic;
                pictureBox14.Image = pic;
                pictureBox15.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox18.Image = pic;
                pictureBox19.Image = pic;
                pictureBox20.Image = pic;
                priceTxtbox1.Clear();
                priceTxtbox2.Clear();
                priceTxtbox3.Clear();
                priceTxtbox4.Clear();
                priceTxtbox5.Clear();
                priceTxtbox6.Clear();
                priceTxtbox7.Clear();
                priceTxtbox8.Clear();
                priceTxtbox9.Clear();
                priceTxtbox10.Clear();
                priceTxtbox11.Clear();
                priceTxtbox12.Clear();
                priceTxtbox13.Clear();
                priceTxtbox14.Clear();
                priceTxtbox15.Clear();
                priceTxtbox16.Clear();
                priceTxtbox17.Clear();
                priceTxtbox18.Clear();
                priceTxtbox19.Clear();
                priceTxtbox20.Clear();
                nameTxtbox1.Clear();
                nameTxtbox2.Clear();
                nameTxtbox3.Clear();
                nameTxtbox4.Clear();
                nameTxtbox5.Clear();
                nameTxtbox6.Clear();
                nameTxtbox7.Clear();
                nameTxtbox8.Clear();
                nameTxtbox9.Clear();
                nameTxtbox10.Clear();
                nameTxtbox11.Clear();
                nameTxtbox12.Clear();
                nameTxtbox13.Clear();
                nameTxtbox14.Clear();
                nameTxtbox15.Clear();
                nameTxtbox16.Clear();
                nameTxtbox17.Clear();
                nameTxtbox18.Clear();
                nameTxtbox19.Clear();
                nameTxtbox20.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog1.ShowDialog();
        }
        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide();
                picpathTxtbox2.Hide();
                picpathTxtbox3.Hide();
                picpathTxtbox4.Hide();
                picpathTxtbox5.Hide();
                picpathTxtbox6.Hide();
                picpathTxtbox7.Hide();
                picpathTxtbox8.Hide();
                picpathTxtbox9.Hide();
                picpathTxtbox10.Hide();
                picpathTxtbox11.Hide();
                picpathTxtbox12.Hide();
                picpathTxtbox13.Hide();
                picpathTxtbox14.Hide();
                picpathTxtbox15.Hide();
                picpathTxtbox16.Hide();
                picpathTxtbox17.Hide();
                picpathTxtbox18.Hide();
                picpathTxtbox19.Hide();
                picpathTxtbox20.Hide();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" + pos_id_comboBox.Text + "','" + nameTxtbox1.Text + "','" + nameTxtbox2.Text + "','" + nameTxtbox3.Text + "','" + nameTxtbox4.Text + "','" + nameTxtbox5.Text + "','" + nameTxtbox6.Text + "','" + nameTxtbox7.Text + "','" + nameTxtbox8.Text + "','" + nameTxtbox9.Text + "','" + nameTxtbox10.Text + "','" + nameTxtbox11.Text + "','" + nameTxtbox12.Text + "','" + nameTxtbox13.Text + "','" + nameTxtbox14.Text + "','" + nameTxtbox15.Text + "','" + nameTxtbox16.Text + "','" + nameTxtbox17.Text + "','" + nameTxtbox18.Text + "','" + nameTxtbox19.Text + "','" + nameTxtbox20.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (pos_id, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('" + priceTxtbox1.Text + "','" + priceTxtbox2.Text + "','" + priceTxtbox3.Text + "','" + priceTxtbox4.Text + "','" + priceTxtbox5.Text + "','" + priceTxtbox6.Text + "','" + priceTxtbox7.Text + "','" + priceTxtbox8.Text + "','" + priceTxtbox9.Text + "','" + priceTxtbox10.Text + "','" + priceTxtbox11.Text + "','" + priceTxtbox12.Text + "','" + priceTxtbox13.Text + "','" + priceTxtbox14.Text + "','" + priceTxtbox15.Text + "','" + priceTxtbox16.Text + "','" + priceTxtbox17.Text + "','" + priceTxtbox18.Text + "','" + priceTxtbox19.Text + "','" + priceTxtbox20.Text +"', '"+ pos_id_comboBox.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" + picpathTxtbox1.Text + "','" + picpathTxtbox2.Text + "','" + picpathTxtbox3.Text + "','" + picpathTxtbox4.Text + "','" + picpathTxtbox5.Text + "','" + picpathTxtbox6.Text + "','" + picpathTxtbox7.Text + "','" + picpathTxtbox8.Text + "','" + picpathTxtbox9.Text + "','" + picpathTxtbox10.Text + "','" + picpathTxtbox11.Text + "','" + picpathTxtbox12.Text + "','" + picpathTxtbox13.Text + "','" + picpathTxtbox14.Text + "','" + picpathTxtbox15.Text + "','" + picpathTxtbox16.Text + "','" + picpathTxtbox17.Text + "','" + picpathTxtbox18.Text + "','" + picpathTxtbox19.Text + "','" + picpathTxtbox20.Text +"', '"+ pos_id_comboBox.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                nameTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nameTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                nameTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                nameTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                nameTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                nameTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                nameTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                nameTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                nameTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                nameTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                nameTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                nameTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                nameTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                nameTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                nameTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                nameTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                nameTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                nameTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                nameTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                nameTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
