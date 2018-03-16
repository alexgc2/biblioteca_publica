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
        SqlCommand cmd, cmp;
        SqlDataReader dr;
        int contador = 0;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=BIBLIOTECA_PUBLICA;integrated security=yes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex);
            }
        }

        public string agregar_libro(string codigo, string nombre, string autor, string editorial, string edicion, string area, string perfil, int isbn, int cantidad, int año, string proveedor, string detalles)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into libros(codigo,nombre,autor, editorial, edicion, area, perfil, isbn, cantidad, año, proveedor, detalles)values('" + codigo + "','" + nombre + "','" + autor + "','" + editorial + "','"+edicion+"','"+area+"','"+perfil+"',"+isbn+","+cantidad+","+año+",'"+proveedor+"','"+detalles+"')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string agregar_autor(string nombre, string colaboracion, string area, string perfil)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into autores(nombre, colaboracion, area, perfil)values('" + nombre + "','" + colaboracion + "','" + area + "','" + perfil + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void llenar_ComboBox(ComboBox cb)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select nombre from autores", cn);
                dr = cmd.ExecuteReader();
                cb.Items.Clear();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string modificar_libro(int id, string codigo, string nombre, string autor, string editorial, string edicion, string area, string perfil, int isbn, int cantidad, int año, string proveedor, string detalles)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update libros set codigo='" + codigo + "', nombre='" + nombre + "', autor='" + autor + "', editorial='" + editorial + "', edicion='" + edicion + "', area='" + area + "', perfil='" + perfil + "', isbn=" + isbn + ", cantidad=" + cantidad + ", año=" + año + ", proveedor='" + proveedor + "', detalles='" + detalles + "' where id_libro="+id+"", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se pudieron actualizar los datos: " + ex.ToString();
            }
            return salida;
        }

        public void llenarModificarLibro(int id, TextBox txtCodigo, TextBox txtNombre,ComboBox cbxAutor, TextBox txtEditorial, TextBox txtEdicion, ComboBox cbxArea, ComboBox cbxPerfil, TextBox txtISBN, TextBox txtCantidad, TextBox txtAño, TextBox txtProveedor, TextBox txtDetalles)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select *from libros where id_libro = "+id+" ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtCodigo.Text = dr["codigo"].ToString();
                    txtNombre.Text = dr["nombre"].ToString();
                    cbxAutor.Text = dr["autor"].ToString();
                    txtEditorial.Text = dr["editorial"].ToString();
                    txtEdicion.Text = dr["edicion"].ToString();
                    cbxArea.Text = dr["area"].ToString();
                    cbxPerfil.Text = dr["perfil"].ToString();
                    txtISBN.Text = dr["isbn"].ToString();
                    txtCantidad.Text = dr["cantidad"].ToString();
                    txtAño.Text = dr["año"].ToString();
                    txtProveedor.Text = dr["proveedor"].ToString();
                    txtDetalles.Text = dr["detalles"].ToString();

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string agregar_TipoMembresia(string nombre, string descripcion, int precio)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into tipo_membresia(nombre, decripcion, precio)values('" + nombre + "','" + descripcion + "'," + precio + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
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

        public void llenar_ComboBoxPago(ComboBox cb)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select nombre from tipo_membresia", cn);
                dr = cmd.ExecuteReader();
                cb.Items.Clear();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenar_TextBoxPago(string nombre,TextBox txt)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select *from tipo_membresia where nombre='"+nombre+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt.Text = (dr["precio"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarModificarMiembro(int id, string sexo, TextBox txtNombre, TextBox txtApellido, ComboBox cbxTipo, TextBox txtTelefono, TextBox txtDireccion, TextBox txtCorreo, TextBox ocupacion, TextBox txtPago)
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
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string modificar_miembro(string nombre, string apellido, string ocupacion, string direccion, string telefono, string sexo, string correo, int costo, string tipo)
        {

            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update membresia set nombre='" + nombre + "',apelido='" + apellido + "',ocupacion='" + ocupacion + "',direccion='" + direccion + "telefono=','" + telefono + "',sexo='" + sexo + "',correo_electronico='" + correo + "costo='," + costo + ",tipo='" + tipo + "')", cn);
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
