using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;


namespace tugasmod6kel5
{
    public partial class ListItems : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-0TBK0IF\\SQLEXPRESS ;Initial Catalog = TugasMod6DB_Kel5; Integrated Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShowLaptop();
                DataShowTipe();
                DataShowLaptoptipe();
            }
        }

        public void DataShowLaptop()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from LAPTOP";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewLaptop.DataSource = ds;
            GridViewLaptop.DataBind();
            con.Close();
        }
        public void DataShowTipe()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            ds = new DataSet();
            cmd.CommandText = "Select * from TIPE";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewTipe.DataSource = ds;
            GridViewTipe.DataBind();
            con.Close();
        }

        public void DataShowLaptoptipe()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            ds = new DataSet();
            cmd.CommandText = "Select * from LAPTOPLIST";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);  
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewLaptoptipe.DataSource = ds;
            GridViewLaptoptipe.DataBind();
            con.Close();
        }

        protected void btnAddLaptop_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into LAPTOP(ID_LAPTOP, NAMA_LAPTOP)values('" + txtIdLaptop.Text + "', '" + txtNamaLaptop.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShowLaptop(); DataShowLaptoptipe();
        }
        protected void btnUpdateLaptop_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update LAPTOP set NAMA_LAPTOP='" + txtNamaLaptop.Text + "' WHERE ID_LAPTOP = '" + txtIdLaptop.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShowLaptop(); DataShowLaptoptipe();
        }
        protected void btnDeleteLaptop_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from LAPTOP where ID_Laptop='" + txtIdLaptop.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShowLaptop(); DataShowLaptoptipe();
        }
        protected void btnClearLaptop_Click(object sender, EventArgs e)
        {
            txtIdLaptop.Text = null;
            txtNamaLaptop.Text = null;
        }

        protected void btnAddTipe_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into TIPE(ID_TIPE, NAMA_TIPE, PROSESSOR, ID_LAPTOP)values('" + txtIdTipe.Text + "', '" + txtNamaTipe.Text + "', '" + txtProsessor.Text + "', '" + txtIdLaptop2.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShowTipe(); DataShowLaptoptipe();
        }

        protected void btnDeleteTipe_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from TIPE where ID_TIPE='" + txtIdTipe.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShowTipe(); DataShowLaptoptipe();
        }

        protected void btnUpdateTipe_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update LAPTOP set NAMA_TIPE='" + txtNamaTipe.Text + "',  PROSESSOR = '" + txtNamaLaptop.Text + "',  ID_LAPTOP = '" + txtIdLaptop2.Text + "' WHERE ID_TIPE = '" + txtIdTipe.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShowTipe(); DataShowLaptoptipe();
        }

        protected void btnClearTipe_Click(object sender, EventArgs e)
        {
            txtIdTipe.Text = null;
            txtNamaTipe.Text = null;
            txtProsessor.Text = null;
            txtIdLaptop2.Text = null;
        }
    }
}
