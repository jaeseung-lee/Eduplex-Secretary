using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentProblem;
using System.Threading;
using System.Collections;

namespace Eduplex_Secretary
{
    public partial class MainForm : Form
    {
        List<Problem> problem_set = new List<Problem>();
        List<string> selected_problem_ids = new List<string>();        

        public MainForm()
        {
            InitializeComponent();
            filterPB.ImageLocation = "../../Icons/filter.png";
            LoadProblemSet();
            LoadcmbYear();
            LoadcmbSource();
            LoadlvwProblems();
            LoadlvwBucket();
        }

        public void LoadProblemSet() {
            problem_set.Add(new Problem("1", 4, 10100, null, 2, 2022, "6월 평가원", 0, 1, 7));
            problem_set.Add(new Problem("2", 5, 20300, null, 2, 2022, "6월 평가원", 0, 2, 12));
            problem_set.Add(new Problem("3", 1, 10500, null, 3, 2022, "6월 평가원", 0, 3, 25));
            problem_set.Add(new Problem("4", 1, 20200, null, 3, 2022, "6월 평가원", 0, 4, 13));
            problem_set.Add(new Problem("5", 3, 20300, null, 3, 2022, "6월 평가원", 0, 5, 12));
            problem_set.Add(new Problem("6", 4, 20800, null, 3, 2022, "6월 평가원", 0, 6, 21));
            problem_set.Add(new Problem("7", 2, 10900, null, 3, 2022, "6월 평가원", 0, 7, 15));
            problem_set.Add(new Problem("8", 4, 20200, null, 3, 2022, "6월 평가원", 0, 8, 24));
            problem_set.Add(new Problem("9", 5, 11000, null, 4, 2022, "6월 평가원", 0, 9, 23));
            problem_set.Add(new Problem("10", 2, 10600, null, 4, 2022, "6월 평가원", 0, 10, 36));
            problem_set.Add(new Problem("11", 2, 20800, null, 4, 2022, "6월 평가원", 0, 11, 49));
            problem_set.Add(new Problem("12", 3, 10700, null, 4, 2022, "6월 평가원", 0, 12, 37));
            problem_set.Add(new Problem("13", 5, 10900, null, 4, 2022, "6월 평가원", 0, 13, 41));
            problem_set.Add(new Problem("14", 3, 20500, null, 4, 2022, "6월 평가원", 0, 14, 63));
            problem_set.Add(new Problem("15", 2, 10600, null, 4, 2022, "6월 평가원", 0, 15, 79));
            problem_set.Add(new Problem("16", 2, 10200, null, 3, 2022, "6월 평가원", 0, 16, 13));
            problem_set.Add(new Problem("17", 11, 20400, null, 3, 2022, "6월 평가원", 0, 17, 20));
            problem_set.Add(new Problem("18", 4, 10800, null, 3, 2022, "6월 평가원", 0, 18, 21));
            problem_set.Add(new Problem("19", 6, 20900, null, 3, 2022, "6월 평가원", 0, 19, 43));
            problem_set.Add(new Problem("20", 8, 20900, null, 4, 2022, "6월 평가원", 0, 20, 79));
            problem_set.Add(new Problem("21", 24, 10100, null, 4, 2022, "6월 평가원", 0, 21, 93));
            problem_set.Add(new Problem("22", 61, 20500, null, 4, 2022, "6월 평가원", 0, 22, 99));

            problem_set.Add(new Problem("23", 2, 10200, null, 2, 2022, "3월 학평", 0, 1, 4));
            problem_set.Add(new Problem("24", 1, 10800, null, 2, 2022, "3월 학평", 0, 2, 4));
            problem_set.Add(new Problem("25", 4, 10600, null, 3, 2022, "3월 학평", 0, 3, 12));
            problem_set.Add(new Problem("26", 1, 20800, null, 3, 2022, "3월 학평", 0, 4, 16));
            problem_set.Add(new Problem("27", 2, 20200, null, 3, 2022, "3월 학평", 0, 5, 7));
            problem_set.Add(new Problem("28", 5, 20200, null, 3, 2022, "3월 학평", 0, 6, 9));
            problem_set.Add(new Problem("29", 5, 11000, null, 3, 2022, "3월 학평", 0, 7, 10));
            problem_set.Add(new Problem("30", 4, 20500, null, 3, 2022, "3월 학평", 0, 8, 11));
            problem_set.Add(new Problem("31", 3, 20900, null, 4, 2022, "3월 학평", 0, 9, 20));
            problem_set.Add(new Problem("32", 5, 10900, null, 4, 2022, "3월 학평", 0, 10, 16));
            problem_set.Add(new Problem("33", 4, 10500, null, 4, 2022, "3월 학평", 0, 11, 19));
            problem_set.Add(new Problem("34", 3, 20500, null, 4, 2022, "3월 학평", 0, 12, 21));
            problem_set.Add(new Problem("35", 3, 10300, null, 4, 2022, "3월 학평", 0, 13, 37));
            problem_set.Add(new Problem("36", 1, 20500, null, 4, 2022, "3월 학평", 0, 14, 26));
            problem_set.Add(new Problem("37", 2, 10700, null, 4, 2022, "3월 학평", 0, 15, 59));
            problem_set.Add(new Problem("38", 10, 20300, null, 3, 2022, "3월 학평", 0, 16, 11));
            problem_set.Add(new Problem("39", 6, 10200, null, 3, 2022, "3월 학평", 0, 17, 22));
            problem_set.Add(new Problem("40", 9, 20700, null, 3, 2022, "3월 학평", 0, 18, 14));
            problem_set.Add(new Problem("41", 162, 10900, null, 3, 2022, "3월 학평", 0, 19, 34));
            problem_set.Add(new Problem("42", 8, 20200, null, 4, 2022, "3월 학평", 0, 20, 50));
            problem_set.Add(new Problem("43", 15, 10700, null, 4, 2022, "3월 학평", 0, 21, 84));
            problem_set.Add(new Problem("44", 16, 20900, null, 4, 2022, "3월 학평", 0, 22, 83));
        }

        public void LoadlvwProblems()
        {
            lvwProblems.View = View.Details;
            lvwProblems.Columns.Add("출제학년도", 80);
            lvwProblems.Columns.Add("출제처", 80);
            lvwProblems.Columns.Add("페이지", 50);
            lvwProblems.Columns.Add("번호", 50);
            lvwProblems.Columns.Add("난이도", 50);
            lvwProblems.Columns.Add("오답률", 50);
            lvwProblems.Columns.Add("ID", 50);
        }

        public void AddProblemInlvwProblems(Problem element)
        {
            String[] item = {
                    element.ProblemYear.ToString(),
                    element.ProblemSource.ToString(),element.ProblemPage.ToString(),
                    element.ProblemNumber.ToString(),element.Level.ToString(),
                    element.WrongRate.ToString(),element.Id.ToString() };
            ListViewItem newitem = new ListViewItem(item);
            lvwProblems.Items.Add(newitem);
        }

        public void LoadcmbYear() {
            cmbYear.Items.Add("전체");
            cmbYear.Items.Add("2022");
            cmbYear.Items.Add("2021");
            cmbYear.Items.Add("2020");
            cmbYear.SelectedIndex = 0;
        }
        public void LoadcmbSource() {
            cmbSource.Items.Add("전체");
            cmbSource.Items.Add("3월 학평");
            cmbSource.Items.Add("4월 학평");
            cmbSource.Items.Add("6월 평가원");
            cmbSource.Items.Add("7월 학평");
            cmbSource.Items.Add("9월 평가원");
            cmbSource.Items.Add("10월 학평");
            cmbSource.Items.Add("수능");
            cmbSource.SelectedIndex = 0;
        }

        public void LoadlvwBucket() {
            lvwBucket.View = View.Details;
            lvwBucket.Columns.Add("출제학년도", 80);
            lvwBucket.Columns.Add("출제처", 80);
            lvwBucket.Columns.Add("페이지", 50);
            lvwBucket.Columns.Add("번호", 50);
            lvwBucket.Columns.Add("난이도", 50);
            lvwBucket.Columns.Add("오답률", 50);
            lvwBucket.Columns.Add("ID", 50);
        }

        private void lvwProblems_Click(object sender, EventArgs e)
        {
            string image_location = "../../Problems/" + lvwProblems.FocusedItem.SubItems[6].Text.ToString() + ".png";
            Bitmap problem_image;
            try
            {
                PBSimpleview.ImageLocation = image_location;
                problem_image = new Bitmap(image_location,true);
                double x = problem_image.Width;
                double y = problem_image.Height;
                double ratio = y / x;
                int height = (int)(ratio * PBSimpleview.Width);
                if (height > 591)
                {
                    height = 591;
                }
                PBSimpleview.Height = height;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("해당 파일이 존재하지 않습니다.");
            }
        }

        private void lvwProblems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!is_in(lvwProblems.FocusedItem))
            {
                int index = find_problem_index(lvwProblems.FocusedItem.SubItems[6].Text.ToString());
                var element = problem_set[index];
                String[] item = {
                    element.ProblemYear.ToString(),
                    element.ProblemSource.ToString(),element.ProblemPage.ToString(),
                    element.ProblemNumber.ToString(),element.Level.ToString(),
                    element.WrongRate.ToString(),element.Id.ToString() };
                ListViewItem newitem = new ListViewItem(item);
                lvwBucket.Items.Add(newitem);
                lvwProblems.FocusedItem.Remove();
            }
            else
            {
                MessageBox.Show("이미 담겨 있는 문제입니다.");
            }
        }

        public bool is_in(ListViewItem target_item)
        {
            string target_id = target_item.SubItems[6].Text.ToString();
            for (int index = 0; index < lvwBucket.Items.Count; index++)
            {
                if(lvwBucket.Items[index].SubItems[6].Text.ToString() == target_id)
                {
                    return true;
                }
            }
            return false;
        }

        public int find_problem_index(string target_id)
        {
            int index = 0;
            foreach(var element in problem_set)
            {
                if(element.Id.Equals(target_id))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void lvwBucket_Click(object sender, EventArgs e)
        {
            string image_location = "../../Problems/" + lvwBucket.FocusedItem.SubItems[6].Text.ToString() + ".png";
            Bitmap problem_image;
            try
            {
                PBSimpleview.ImageLocation = image_location;
                problem_image = new Bitmap(image_location, true);
                double x = problem_image.Width;
                double y = problem_image.Height;
                double ratio = y / x;
                int height = (int)(ratio * PBSimpleview.Width);
                if (height > 591)
                {
                    height = 591;
                }
                PBSimpleview.Height = height;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("해당 파일이 존재하지 않습니다.");
            }
        }

        private void lvwBucket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = find_problem_index(lvwBucket.FocusedItem.SubItems[6].Text.ToString());
            AddProblemInlvwProblems(problem_set[index]);
            lvwBucket.FocusedItem.Remove();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("activated");
            if (lvwBucket.Items.Count == 0)
            {
                MessageBox.Show("담긴 문제가 없습니다.");
                return;
            }
            MessageBox.Show(lvwBucket.Items.Count + " 문제가 담긴 문제집이 생성되었습니다.");
            for (int count = 0; count < lvwBucket.Items.Count; count++)
            {
                selected_problem_ids.Add(lvwBucket.Items[count].SubItems[6].Text.ToString());
            }
            ProblemDetailForm pdf = new ProblemDetailForm(selected_problem_ids,problem_set);
            pdf.Show();
            selected_problem_ids.Clear();
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selectedindex : " + cmbSource.SelectedIndex);
            if (cmbSource.SelectedIndex == 0)
            {
                lvwProblems.Items.Clear();
                foreach (var element in problem_set)
                {
                    AddProblemInlvwProblems(element);
                }
            }
            else
            {
                lvwProblems.Items.Clear();
                foreach (var element in problem_set)
                {
                    if(cmbSource.SelectedItem.ToString() == element.ProblemSource)
                    {
                        AddProblemInlvwProblems(element);
                    }
                }
            }
        }

        private void lvwProblems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.lvwProblems.ListViewItemSorter = new lvwProblemsComparer(e.Column);
        }
    }

    class lvwProblemsComparer : IComparer
    {
        private int col;
        public lvwProblemsComparer()
        {
            col = 0;
        }
        public lvwProblemsComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            switch (col)
            {
                case 5:
                    return -Int32.Parse(((ListViewItem)x).SubItems[col].Text) + Int32.Parse(((ListViewItem)y).SubItems[col].Text);
                case 3:
                    return Int32.Parse(((ListViewItem)x).SubItems[col].Text) - Int32.Parse(((ListViewItem)y).SubItems[col].Text);
                case 4:
                    return -Int32.Parse(((ListViewItem)x).SubItems[col].Text) + Int32.Parse(((ListViewItem)y).SubItems[col].Text);
                default:
                    return 0;
            }
        }
    }
}
