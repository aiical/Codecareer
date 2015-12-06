using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace P15_3
{
    public partial class Default : System.Web.UI.Page
    {
        List<Province> provinces;
        List<City> cities;
        List<Scene> scenes;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                provinces = (List<Province>)Cache["provinces"];
                cities = (List<City>)Cache["cities"];
                scenes = (List<Scene>)Cache["scenes"];
                return;
            }
            string sConn = ConfigurationManager.ConnectionStrings["GeoConnectionString"].ConnectionString;
            IDbConnection conn = new System.Data.OleDb.OleDbConnection(sConn);
            try
            {
                conn.Open();
                Cache["provinces"] = provinces = Province.LoadAll(conn);
                Cache["cities"] = cities = City.LoadAll(conn, provinces);
                Cache["scenes"] = scenes = Scene.LoadAll(conn, cities);
                DropDownList1.DataSource = provinces;
                DropDownList1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("数据访问错误:" + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IGrouping<City, Scene>[] sGroups = (from s in scenes
                      where s.City.Province.Name == DropDownList1.SelectedValue
                      group s by s.City).ToArray();
            Label1.Text = sGroups[0].Key.Name;
            GridView1.DataSource = sGroups[0];
            GridView1.DataBind();
            Cache["result"] = sGroups;
            Cache["current"] = 0;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Cache["result"] == null)
                return;
            IGrouping<City, Scene>[] sGroups = (IGrouping<City, Scene>[])Cache["result"];
            int current = (int)Cache["current"];
            if (++current == sGroups.Length)
                current = 0;
            Label1.Text = sGroups[current].Key.Name;
            GridView1.DataSource = sGroups[current];
            GridView1.DataBind();
            Cache["current"] = current;
        }
    }
}