using System.Data;
using System.Data.SqlClient;
 
public partial class test_ImageUploding : System.Web.UI.Page
{
    // sql connection
    SqlConnection con = new SqlConnection(@"Data Source=MIHIR-PC\SQL;Initial
                                           Catalog=db_Student;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridView();
        }
    }
    //method for binding GridView
    protected void BindGridView()
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select ID, Name,Branch,City,Image from tbl_student"
                                                                                                                 , con);
        con.Open();
        da.Fill(dt);
        con.Close();
 
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
 
    // edit event
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGridView();
 
    }
    // update event
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //find student id of edit row
        string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        // find values for update
        TextBox name = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_Name");
 
        FileUpload FileUpload1 = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1");
 
        string path = "~/Images/UserImage/";
        if (FileUpload1.HasFile)
        {
            path += FileUpload1.FileName;
            //save image in folder
            FileUpload1.SaveAs(MapPath(path));
        }
        else
        {
            // use previous user image if new image is not changed
            Image img = (Image)GridView1.Rows[e.RowIndex].FindControl("img_user");
            path = img.ImageUrl;
        }
 
        SqlCommand cmd = new SqlCommand("update tbl_student set Name='" + name.Text + "',
                                                                                                image='"+path+"'  where ID=" + id + "", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
 
        GridView1.EditIndex = -1;
        BindGridView();
    }
    // cancel edit event
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGridView();
    }
}
