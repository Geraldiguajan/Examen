namespace FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
public class Alumno
{
    public string DNI { get; set; }
    public string Apellidos { get; set; }
    public string Nombre { get; set; }
    public double Nota { get; set; }
    public string Calificacion => CalcularCalificacion();

    public Alumno(string dni, string apellidos, string nombre, double nota)
    {
        DNI = dni;
        Apellidos = apellidos;
        Nombre = nombre;
        Nota = nota;
    }

    private string CalcularCalificacion()
    {
        if (Nota < 5) return "SS";
        else if (Nota < 7) return "AP";
        else if (Nota < 9) return "NT";
        else return "SB";
    }
}

public class GestionAlumnos
{
    public Dictionary<string, Alumno> Alumnos { get; private set; } = new Dictionary<string, Alumno>();

    public void IntroducirAlumno(string dni, string apellidos, string nombre, double nota)
    {
        if (!Alumnos.ContainsKey(dni))
            Alumnos[dni] = new Alumno(dni, apellidos, nombre, nota);
    }

    public void EliminarAlumno(string dni)
    {
        Alumnos.Remove(dni);
    }
}

public class MainForm : Form
{
    private GestionAlumnos gestion = new GestionAlumnos();
    private ListBox listBoxAlumnos = new ListBox();
    private Button btnAgregar = new Button { Text = "Agregar Alumno" };
    private Button btnEliminar = new Button { Text = "Eliminar Alumno" };

    public MainForm()
    {
        Text = "Gestión de Calificaciones";
        Width = 400;
        Height = 300;

        listBoxAlumnos.Top = 10;
        listBoxAlumnos.Left = 10;
        listBoxAlumnos.Width = 360;
        listBoxAlumnos.Height = 180;

        btnAgregar.Top = 200;
        btnAgregar.Left = 10;
        btnAgregar.Click += (sender, e) => {
            string dni = "12345";
            gestion.IntroducirAlumno(dni, "Perez", "Juan", 8.5);
            ActualizarLista();
        };

        btnEliminar.Top = 200;
        btnEliminar.Left = 120;
        btnEliminar.Click += (sender, e) => {
            if (listBoxAlumnos.SelectedItem != null)
            {
                string dni = listBoxAlumnos.SelectedItem.ToString().Split(' ')[0];
                gestion.EliminarAlumno(dni);
                ActualizarLista();
            }
        };

        Controls.Add(listBoxAlumnos);
        Controls.Add(btnAgregar);
        Controls.Add(btnEliminar);
    }

    private void ActualizarLista()
    {
        listBoxAlumnos.Items.Clear();
        foreach (var alumno in gestion.Alumnos.Values)
        {
            listBoxAlumnos.Items.Add($"{alumno.DNI} {alumno.Apellidos}, {alumno.Nombre} {alumno.Nota} {alumno.Calificacion}");
        }
    }
}

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}

