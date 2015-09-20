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
        private static List<Problem> problems = new List<Problem>();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == "ProjectEuler.Problems"
                    select t;
            q.ToList().ForEach(t => addProblemToList(t.FullName));
        }

        private void addProblemToList(string strNamespace)
        {           
            Type t = Type.GetType(strNamespace);
            dynamic p = Activator.CreateInstance(t);
            listBox1.Items.Add(p.name + " - " + p.description);                   
        }


    }
}
