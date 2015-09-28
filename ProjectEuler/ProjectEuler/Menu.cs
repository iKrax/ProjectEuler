using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ProjectEuler
{
    public partial class Menu : Form
    {
        List<string> problemList = new List<string>();
        List<string> filteredList = new List<string>();

        public Menu()
        {
            InitializeComponent();
        }

        //Run on load, add problems to list
        private void Menu_Load(object sender, EventArgs e)
        {
            getListOfProblems().ForEach(t => addProblemToList(t));
            updateListBox();
        }

        //Execute button
        private void button1_Click(object sender, EventArgs e)
        {
            executeProblem();
        }

        //Filter    
        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {
            filteredList.Clear();
            filteredList.AddRange(problemList.Where(t => t.ToLower().Contains(txt_Filter.Text.ToLower())));
            updateListBox();
        }

        //Update list box depending on predicament
        private void updateListBox()
        {
            listBox1.Items.Clear();

            if(txt_Filter.Text == "")
            {
                problemList.ForEach(i => listBox1.Items.Add(i));
            } else
            {
                filteredList.ForEach(i => listBox1.Items.Add(i));
            }

            //Reverse list box so correctly sorted
            for (int i = 0; i < listBox1.Items.Count / 2; i++)
            {
                var tmp = listBox1.Items[i];
                listBox1.Items[i] = listBox1.Items[listBox1.Items.Count - i - 1];
                listBox1.Items[listBox1.Items.Count - i - 1] = tmp;
            }
        }

        //Get list of problems in problems namespace
        private List<Type> getListOfProblems()
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == "ProjectEuler.Problems"
                    select t;

            return q.ToList();
        }

        //Add to cache list
        private void addProblemToList(Type t)
        {           
            dynamic p = Activator.CreateInstance(t);
            problemList.Add(p.ToString());                            
        }

        //Execute selected problem
        private void executeProblem()
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                dynamic problem = Activator.CreateInstance(getListOfProblems()[problemList.IndexOf(listBox1.SelectedItem.ToString())]);
                MessageBox.Show(problem.execute().ToString());               
            }         
        }

    }
}
