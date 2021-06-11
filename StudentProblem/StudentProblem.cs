using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem
{
    public class Person
    {
        string name; // 이름
        string id; // id
        string password; // password

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

    public class Student : Person
    {
        int grade; //학년 - ex) 7 = 중학교 1학년, 10 = 고등학교 1학년
        List<KeyValuePair<string, bool>> problem_records; // 어떤 문제를 맞췄고, 어떤 문제를 틀렸는지에 대한 기록
        public Student() { }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public List<KeyValuePair<string,bool>> ProblemRecords
        {
            get { return problem_records; }
            set { problem_records = value; }
        }

        //문제 푼 기록을 추가하는 함수
        //한 번 푼 문제를 또 풀 수 있으므로 따로 확인하지 않음.
        public void AddProblemRecord(string problem_id, bool is_right)
        {
            KeyValuePair<string, bool> temp_record = new KeyValuePair<string, bool>(problem_id,is_right);
            problem_records.Add(temp_record);
        }
    }

    public class Manager : Person
    {
        List<Student> students; // 담당하는 학생들

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
    }

    public class Problem
    {
        public Problem(string id, int answer, int unit_code, List<int> attributes,
            int level,int problem_year,string problem_source,int problem_page,int problem_number, double wrong_rate)
        {
            this.id = id;
            this.answer = answer;
            this.unit_code = unit_code;
            this.attributes = attributes;
            this.level = level;
            this.problem_year = problem_year;
            this.problem_source = problem_source;
            this.problem_page = problem_page;
            this.problem_number = problem_number;
            this.wrong_rate = wrong_rate;
        }
        string id; // 문제 아이디 - 문제 그림 이름으로 저장되어있음
        int answer; // 문제 정답
        int unit_code; // 단원코드 : 아래에다가 써놓을 예정
        List<int> attributes; // 문제의 세부유형 : 아래에 써놓을 예정
        int level; // 문제 난이도 2점/3점/4점(4점쉬운거)/5점(4점킬러)
        int problem_year; // 출제된 학년도 : 2022학년도
        string problem_source; // 출제된 시험지 혹은 책 이름 : 6월평가원, 수능특강, 3월학평
        int problem_page; // 출제된 페이지 : 책이면 페이지를, 시험지면 0을 넣는다.
        int problem_number; // 문제 번호 : 3
        double wrong_rate; // 오답률 : 시험이면 오답률을, 책이면 -1을 기입

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public int UnitCode
        {
            get { return unit_code; }
            set { unit_code = value; }
        }

        public List<int> Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int ProblemYear
        {
            get { return problem_year; }
            set { problem_year = value; }
        }

        public string ProblemSource
        {
            get { return problem_source; }
            set { problem_source = value; }
        }

        public int ProblemPage
        {
            get { return problem_page; }
            set { problem_page = value; }
        }

        public int ProblemNumber
        {
            get { return problem_number; }
            set { problem_number = value; }
        }

        public double WrongRate
        {
            get { return wrong_rate; }
            set { wrong_rate = value; }
        }

        /*
         * 단원명
         수1                코드  |     수2            코드
         지수               10100 | 함수의 극한        20100
         로그               10200 | 함수의 연속        20200      
         지수함수           10300 | 미분계수와 도함수  20300
         로그함수           10400 | 도함수의활용(1)    20400
         삼각함수           10500 | 도함수의활용(2)    20500
         삼각함수의 그래프  10600 | 도함수의활용(3)    20600
         삼각함수의 활용    10700 | 부정적분           20700
         등차수열과 등비수열10800 | 정적분             20800
         수열의 합          10900 | 정적분활용         20900
         수학적 귀납법      11000 |

         * 문제 세부유형             | 코드
         기타 신유형                 | 0
         단순 계산                   | 1
         그래프 그려서 조사하기      | 2
         정수론                      | 3
         중학교 기하                 | 4
         절대값 기호                 | 5
         가우스 기호                 | 6
         새롭게 정의된 함수 해석하기 | 7
         최대 최소 구하기            | 8
         새로운 집합 해석하기        | 9
         주어진 그래프 해석하기      | 10
         고등수학(상)                | 11           
         고등수학(하)                | 12
         */
    }
}
