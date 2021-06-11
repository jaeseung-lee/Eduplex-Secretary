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

namespace Eduplex_Secretary
{
    public partial class ProblemDetailForm : Form
    {
        List<string> selected_ids;
        List<Problem> problem_set = new List<Problem>();
        int selected_index= 0;

        //어떤 학생이 6월평가원에서 14,15,20,21 번을 틀리고, 3월 모의 평가에서 11,12,14,15,20,21,22를 틀렸다고 하자.
        List<KeyValuePair<string, bool>> problem_records = new List<KeyValuePair<string, bool>>();
        public void set_problem_records()
        {
            foreach (var element in problem_set)
            {
                if (element.Id != "14" && element.Id != "15" && element.Id != "20" && element.Id != "21" && element.Id != "33" 
                    && element.Id != "36" && element.Id != "37" && element.Id != "42" && element.Id != "43" && element.Id != "44")
                {
                    KeyValuePair<string, bool> temp = new KeyValuePair<string, bool>(element.Id, true);
                    problem_records.Add(temp);
                }
                else
                {
                    KeyValuePair<string, bool> temp = new KeyValuePair<string, bool>(element.Id, false);
                    problem_records.Add(temp);
                }
            }
        }

        public void calculate(Problem target_problem)
        {
            int unitcode = target_problem.UnitCode;
            int level = target_problem.Level;

            double w = wrong_problems();
            double c = right_problems();
            double p_w = w / (w + c);
            double p_c = c / (w + c);
            double p_uc_w = (find_uc_w(unitcode)+1)/(w+1);
            double p_uc_c = (find_uc_c(unitcode)+1)/(c+1);
            double p_lv_w = (find_lv_w(level)+1)/(w+1);
            double p_lv_c = (find_lv_c(level)+1)/(c+1);
            double wrong_rate = p_w * p_uc_w * p_lv_w;
            double right_rate = p_c * p_uc_c * p_lv_c;
            double _wrong_rate = wrong_rate / (wrong_rate + right_rate);
            double _right_rate = right_rate / (wrong_rate + right_rate);
            Console.WriteLine("wrong_problems : {0}, right_problems : {1}",p_w,p_c);
            Console.WriteLine("{0}, {1}, {2}, {3}",p_uc_w,p_uc_c,p_lv_w,p_lv_c);
            Console.WriteLine("wrong_rate : " + _wrong_rate + " right_rate : " + _right_rate);
        }

        public int wrong_problems()
        {
            int answer = 0;
            foreach(var element in problem_records)
            {
                if (!element.Value)
                {
                    answer++;
                }
            }
            return answer;
        }

        public int right_problems()
        {
            int answer = 0;
            foreach (var element in problem_records)
            {
                if (element.Value)
                {
                    answer++;
                }
            }
            return answer;
        }

        //나중에 id로 문제의 index를 가져오는 함수를 만들어야함.
        public int get_problem_index(string problem_id)
        {
            int answer = 0;
            foreach(var element in problem_set)
            {
                if(element.Id == problem_id)
                {
                    return answer;
                }
                answer++;
            }
            return -1;
        }

        public int find_uc_w(int unitcode)
        {
            int answer = 0;
            foreach (var element in problem_records)
            {
                if (!element.Value&&problem_set[get_problem_index(element.Key)].UnitCode == unitcode)
                {
                    answer++;
                }
            }
            return answer;
        }

        public int find_uc_c(int unitcode)
        {
            int answer = 0;
            foreach (var element in problem_records)
            {
                if (element.Value && problem_set[get_problem_index(element.Key)].UnitCode == unitcode)
                {
                    answer++;
                }
            }
            return answer;
        }

        public int find_lv_w(int level)
        {
            int answer = 0;
            foreach (var element in problem_records)
            {
                if (element.Value && problem_set[get_problem_index(element.Key)].Level == level)
                {
                    answer++;
                }
            }
            return answer;
        }

        public int find_lv_c(int level)
        {
            int answer = 0;
            foreach (var element in problem_records)
            {
                if (element.Value && problem_set[get_problem_index(element.Key)].Level == level)
                {
                    answer++;
                }
            }
            return answer;
        }

        public ProblemDetailForm(List<string> selected_problem_ids, List<Problem> problems)
        {
            InitializeComponent();
            selected_ids = selected_problem_ids;
            problem_set = problems;

            LoadPBMain();
            Loadlvw();
            set_problem_records();
            foreach(var element in selected_ids)
            {
                calculate(problem_set[Int32.Parse(element)]);
            }
        }

        public void LoadPBMain()
        {
            ResizePBMain(selected_ids[selected_index]);
            //Mirror도 설정해야함
            //ResizePBMirror(비슷한 id);
        }   

        public void ResizePBMain(string target_id)
        {
            string image_location = "../../Problems/" + target_id + ".png";
            Bitmap problem_image;
            try
            {
                ProblemPB.ImageLocation = image_location;
                problem_image = new Bitmap(image_location, true);
                double x = problem_image.Width;
                double y = problem_image.Height;
                double ratio = y / x;
                int height = (int)(ratio * ProblemPB.Width);
                if (height > 434)
                {
                    height = 434;
                }
                ProblemPB.Height = height;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("해당 파일이 존재하지 않습니다.");
            }
        }

        public void ResizePBMirror(string target_id)
        {
            string image_location = "../../Problems/" + target_id + ".png";
            Bitmap problem_image;
            try
            {
                PBMirror.ImageLocation = image_location;
                problem_image = new Bitmap(image_location, true);
                double x = problem_image.Width;
                double y = problem_image.Height;
                double ratio = y / x;
                int height = (int)(ratio * PBMirror.Width);
                if (height > 434)
                {
                    height = 434;
                }
                PBMirror.Height = height;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("해당 파일이 존재하지 않습니다.");
            }
        }

        public void Loadlvw()
        {
            lvwMain.View = View.Details;
            lvwMain.Columns.Add("출제학년도", 80);
            lvwMain.Columns.Add("출제처", 80);
            lvwMain.Columns.Add("페이지", 50);
            lvwMain.Columns.Add("번호", 50);
            lvwMain.Columns.Add("난이도", 50);
            lvwMain.Columns.Add("오답률", 50);
            lvwMain.Columns.Add("ID", 50);

            lvwMirror.View = View.Details;
            lvwMirror.Columns.Add("출제학년도", 80);
            lvwMirror.Columns.Add("출제처", 80);
            lvwMirror.Columns.Add("페이지", 50);
            lvwMirror.Columns.Add("번호", 50);
            lvwMirror.Columns.Add("난이도", 50);
            lvwMirror.Columns.Add("오답률", 50);
            lvwMirror.Columns.Add("ID", 50);
            lvwMirror.Columns.Add("유사도", 50);

            foreach(string id in selected_ids)
            {
                Problem target_problem = problem_set[FindTargetIndex(id)];
                string[] item = {target_problem.ProblemYear.ToString(),
                    target_problem.ProblemSource.ToString(),target_problem.ProblemPage.ToString(),
                    target_problem.ProblemNumber.ToString(),target_problem.Level.ToString(),
                    target_problem.WrongRate.ToString(),target_problem.Id};
                ListViewItem _item = new ListViewItem(item);
                lvwMain.Items.Add(_item);
            }
        }

        public int FindTargetIndex(string target_id)
        {
            int count = 0;
            foreach(var problem in problem_set)
            {
                if(problem.Id == target_id)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말 종료하시겠습니까?", "경고",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                this.Close();
        }

        private void lvwMain_DoubleClick(object sender, EventArgs e)
        {
            ResizePBMain(lvwMain.FocusedItem.SubItems[6].Text.ToString());
        }
    }
}
