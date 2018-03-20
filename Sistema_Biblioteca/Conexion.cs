using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Sistema_Biblioteca
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;//
        DataSet ds;
        string query;
        SqlDataAdapter da;

        public Conexion()
        {
            try
            {
                //cn = new SqlConnection("Data Source=.;Initial Catalog=BIBLIOTECA_PUBLICA;integrated security=yes");
                cn = new SqlConnection(@"Data Source=LAPTOP-SPOD9GPG\SQLEXPRESS;Initial Catalog=BIBLIOTECA_PUBLICA;Integrated Security=False;Trusted_Connection=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex);
            }
        }

        public string agregar_libro(string codigo, string nombre, string autor, string editorial, string edicion, string area, string perfil, int isbn, int cantidad, int año, string proveedor, DateTimePicker date)
        {

            string salida = "Registrado Exitosamente";
            string fecha = date.Value.Date.ToShortDateString();
            
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into libros(codigo,nombre,autor, editorial, edicion, area, perfil, isbn, cantidad, año, proveedor, fecha)values('" + codigo + "','" + nombre + "','" + autor + "','" + editorial + "','"+edicion+"','"+area+"','"+perfil+"',"+isbn+","+cantidad+","+año+",'"+proveedor+"','"+fecha+"')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string agregar_autor(string nombre, string area, string perfil)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into autores(nombre, area, perfil)values('" + nombre + "','" + area + "','" + perfil + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public int autor_registrado(string nombre)// verifica si existe un autor con el mismo nombre
        {

            int contador = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from autores where nombre like '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar: " + ex.ToString());
            }
            return contador;
        }

        public string modificar_libro(string codigo, string nombre, string autor, string editorial, string edicion, string area, string perfil, int isbn, int cantidad, int año, string proveedor, string status)
        {
            //string fecha = date.Value.Date.ToShortDateString();
            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update libros set nombre='" + nombre + "', autor='" + autor + "', editorial='" + editorial + "', edicion='" + edicion + "', area='" + area + "', perfil='" + perfil + "', isbn=" + isbn + ", cantidad=" + cantidad + ", año=" + año + ", proveedor='" + proveedor + "', status='"+status+"' where codigo='"+codigo+"'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se pudieron actualizar los datos: " + ex.ToString();
            }
            return salida;
        }

        public void llenarModificarLibro(TextBox txtCodigo, TextBox txtTitulo, TextBox Autor, TextBox txtEditorial, TextBox txtEdicion, TextBox Area, TextBox txtPerfil, TextBox txtISBN, TextBox txtCantidad, TextBox txtAño, TextBox txtProveedor, ComboBox txtStatus, TextBox Fecha)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select *from libros where codigo = "+txtCodigo.Text+" ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTitulo.Text = dr["nombre"].ToString();
                    Autor.Text = dr["autor"].ToString();
                    txtEditorial.Text = dr["editorial"].ToString();
                    txtEdicion.Text = dr["edicion"].ToString();
                    Area.Text = dr["area"].ToString();
                    txtPerfil.Text = dr["perfil"].ToString();
                    txtISBN.Text = dr["isbn"].ToString();
                    txtCantidad.Text = dr["cantidad"].ToString();
                    txtAño.Text = dr["año"].ToString();
                    txtProveedor.Text = dr["proveedor"].ToString();
                    txtStatus.Text = dr["status"].ToString();
                    Fecha.Text = dr["Fecha"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string agregar_TipoMembresia(string nombre, int precio)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into tipo_membresia(TIPO, precio)values('" + nombre + "'," + precio + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
       
        public int membresia_registrada(string nombre)// verifica si existe una membresia con el mismo nombre
        {

            int contador = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from tipo_membresia where TIPO like '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar: " + ex.ToString());
            }
            return contador;
        }


        public DataSet ConsultarLibros(string nombre)
        {
            query = "select codigo, isbn, autor, nombre, area, perfil  from LIBROS where STATUS = 'ACTIVO' ";
            if (nombre != "")
                query +="and nombre like '%" + nombre + "%'";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "LIBROS");
            cn.Open();
            dr = cmd.ExecuteReader();
            cn.Close();
            return ds;
        }


        public DataSet ConsultarMiembros(string Filtro)
        {
            query = "select id_miembro, nombre, apellido, ocupacion, telefono, tipo, status  from membresia where STATUS = 'ACTIVO' ";
            if (Filtro != "")
                query += "and nombre like '%" + Filtro + "%' or apellido like '%" + Filtro + "%'";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "membresia");
            cn.Open();
            dr = cmd.ExecuteReader();
            cn.Close();
            return ds;
        }

        public DataSet ConsultarAutores(string Filtro)
        {
            query = "select nombre, area, perfil from autores ";
            if (Filtro != "")
                query += "where nombre like '%" + Filtro + "%'";

            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "autores");
            cn.Open();
            dr = cmd.ExecuteReader();
            cn.Close();
            return ds;
        }

        public void llenarModificarMiembro(int id, string sexo, TextBox txtNombre, TextBox txtApellido, TextBox cbxTipo, TextBox txtTelefono, TextBox txtDireccion, TextBox txtCorreo, TextBox ocupacion, TextBox txtPago, ComboBox txtStatus)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select *from membresia where id_miembro = " + id + " ", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtApellido.Text = dr["apellido"].ToString();
                    txtNombre.Text = dr["nombre"].ToString();
                    ocupacion.Text = dr["ocupacion"].ToString();
                    sexo = dr["sexo"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtCorreo.Text = dr["correo_electronico"].ToString();
                    txtPago.Text = dr["Costo"].ToString();
                    cbxTipo.Text = dr["tipo"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtStatus.Text = dr["status"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string agregar_miembro(string nombre, string apellido, string ocupacion, string direccion, string telefono, string sexo, string correo, int costo, string tipo)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into membresia(nombre,apellido,ocupacion,direccion,telefono,sexo,correo_electronico,costo,tipo)values('" + nombre + "','" + apellido + "','" + ocupacion + "','" + direccion + "','" + telefono + "','" + sexo + "','" + correo + "'," + costo + ",'" + tipo + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string modificar_miembro(int id, string nombre, string apellido, string ocupacion, string direccion, string telefono, string sexo, string correo, int costo, string tipo, string status)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update membresia set nombre='" + nombre + "',apellido='" + apellido + "',ocupacion='" + ocupacion + "',direccion='" + direccion + "', telefono='" + telefono + "',sexo='" + sexo + "',correo_electronico='" + correo + "',costo=" + costo + ",tipo='" + tipo + "', status='" + status + "' where id_miembro=" + id + "", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }   
     
    }
}
