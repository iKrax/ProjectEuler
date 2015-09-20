using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEuler
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            getListOfProblems().ForEach(t => addProblemToList(t));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            executeProblem();
        }

        private List<System.Type> getListOfProblems()
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == "ProjectEuler.Problems"
                    select t;

            return q.ToList();
        }

        private void addProblemToList(Type t)
        {           
            dynamic p = Activator.CreateInstance(t);
            listBox1.Items.Add(p.name + " - " + p.description);                   
        }

        private void executeProblem()
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                dynamic problem = Activator.CreateInstance(getListOfProblems()[listBox1.SelectedIndex]);
                MessageBox.Show(problem.execute().ToString());               
            }         
        }

 
    }
}
