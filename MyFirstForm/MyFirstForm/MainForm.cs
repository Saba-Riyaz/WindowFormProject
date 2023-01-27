using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class frmPersonl : Form
    {
        string name, fname, email, postAdrs, cellNo, relign, cnic, gender, mrtStats, DOB,
             matric, inter, uni,
             country, city, province;
        short my, iy, uy;
        char mGrad, iGrad, uGrad;


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            fname = txtFName.Text;
            email = txtEmail.Text;
            postAdrs = txtPadd.Text;
            cellNo = txtCellno.Text;
            relign = txtRel.Text;
            cnic = txtCNIC.Text;
            DOB = DtpDOB.Text;
            my = short.Parse(txtMyear.Text); matric = txtMatric.Text; mGrad = char.Parse(txtMgd.Text);

            iy = short.Parse(txtMInter.Text); inter = txtCollege.Text; iGrad = char.Parse(txtcollegeGd.Text);

            uy = short.Parse(txtUniyear.Text); uni = txtUni.Text; uGrad = char.Parse(txtUniGd.Text); 

            country = cboCoun.Text;
            city = cboCity.Text;
            province = cboPro.Text;


            MessageBox.Show("Name : " + name + '\n'+
                "Father Name : "+ fname + '\n'+
                "Email : " + email +'\n'+
                "Postal Address : " + postAdrs + '\n' +
                " Cell No : " + cellNo + '\n' + 
                "Religion : " + relign  + '\n' +
                "CNIC : " + cnic + '\n' + "..............................." +'\n' +
                 "Gender : " + gender + '\n' +
                "Martial Status : " + mrtStats + '\n' + "..................................."+ '\n' +
                "Year : " + my + '\n' + " Matric : " + matric + '\n' + " Grade : " + mGrad + '\n' + "....................................." + '\n' +
                " Year : " + iy + '\n' + " College : " + inter + '\n' + " Grade : " + iGrad + '\n' + "......................................." + '\n' +
                " Year : " + uy + '\n' + " University : " + uni + '\n' + " Grade : " + uGrad + '\n' + ".........................................." + '\n' +
                " Country : " + country + '\n' + " City : " + city + '\n' + " Province : " + province + '\n' +
                "");



            if (rdbM.Checked)
            {
                gender = rdbM.Text;
            }
            else
            {
                gender = rdbF.Text;
            }

            if (rdbS.Checked)
            {
                mrtStats = rdbS.Text;
            }
            else
            {
                mrtStats = rdbMa.Text;
            }
        }

        public frmPersonl()
        {
            InitializeComponent();
            
        }
   
    }
}
