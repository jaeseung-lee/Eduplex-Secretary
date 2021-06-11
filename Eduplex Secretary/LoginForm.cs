using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduplex_Secretary
{
    public partial class LoginForm : Form
    {
        public enum TextBoxParseCase
        {
            None,
            ID,
            PW
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        public TextBoxParseCase GetTextBoxParseCase()
        {
            if(TBid.Text == "")
            {
                return TextBoxParseCase.ID;
            }
            else if(TBpw.Text == "")
            {
                return TextBoxParseCase.PW;
            }
            else
            {
                return TextBoxParseCase.None;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            switch (GetTextBoxParseCase())
            {
                case TextBoxParseCase.ID:
                    MessageBox.Show("아이디를 입력해주세요.");
                    return;
                case TextBoxParseCase.PW:
                    MessageBox.Show("비밀번호를 입력해주세요.");
                    return;
                case TextBoxParseCase.None:
                    if (!CheckValidIDPW())
                    {
                         MessageBox.Show("비밀번호를 다시 입력해주세요.");
                         return;
                    }
                    break;
            }
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        //아직 안 만듦
        public bool CheckValidIDPW()
        {
            return true;
        }
    }
}
