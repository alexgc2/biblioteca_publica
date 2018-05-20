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

        public string BuscarIDEmpleado()
        {
            string id = "error";
            cn.Open();
            cmd = new SqlCommand("select ID_EMPLEADO From EMPLEADO", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["ID_EMPLEADO"].ToString();
            }
            dr.Close();
            cn.Close();
            return id;
        }


        public string agregar_libro(string codigo, string nombre, string autor, string editorial, string edicion, string area, string perfilLibro , string perfilAutor, int isbn, int cantidad, int año, string proveedor, DateTimePicker date, string id_autor)
        {

            string salida = "Registrado Exitosamente";
            string fecha = date.Value.Date.ToShortDateString();
            
            try
            {
                if (id_autor == null)
                {
                    id_autor = BuscarIDAutor(autor, area, perfilAutor);
                }
                cn.Open();
                cmd = new SqlCommand("insert into libros(codigo,nombre, editorial, edicion, perfil, isbn, cantidad, año, proveedor, fecha, id_autor)values('" + codigo + "','" + nombre + "','" + editorial + "','"+edicion+"','"+perfilLibro+"',"+isbn+","+cantidad+","+año+",'"+proveedor+"','"+fecha+"', "+id_autor+")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                cn.Close();
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string RegistrarPrestamoSalas(string id_sala, string id_empleado, string id_miembro_encargado,
            string nombre_evento, string fecha_evento, string duracion, string num_asistentes)
        {
            string salida = "OK";
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("insert into prestamo_salas(id_sala, id_empleado, id_miembro_encargado," +
                    " nombre_evento, fecha_evento, duracion, num_asistentes)" +
                    "values({0},{1},{2},'{3}','{4}', '{5}', '{6}')", 
                    id_sala, id_empleado, id_miembro_encargado, nombre_evento, fecha_evento, duracion, num_asistentes)
                    , cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cn.Close();
            }
            return salida;
        }

        public string agregar_empleado(string nombre, string apellidos, string direccion, string contraseña, 
            string fecha_nacimiento, string sexo, string telefono)
        {

            string salida = "OK";
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("insert into empleado(nombre, apellidos, dirección, contraseña, fecha_nacimiento," +
                    "sexo, telefono) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',{6})",
                    nombre, apellidos, direccion, contraseña, fecha_nacimiento, sexo, telefono), cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cn.Close();
            }
            return salida;

        }

        public string BuscarIDAutor(string nombre, string autor, string perfil) {
            string id;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select id_autors from autores where nombre = '"+nombre + "' and area = '" + autor+ "' and perfil = '" +perfil+ "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["id_autors"].ToString();
                    dr.Close();
                    cn.Close();
                    return id;
                }
            }
            catch (Exception)
            {
                throw;
            }
            dr.Close();
            cn.Close();
            return "-1";
        }

        public string RegistrarPrestamoLibro(string id_miembro, string id_libro, string id_empleado, string fecha_prestamo, string fecha_entrega)
        { 
            string salida = "OK";
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("insert into prestamo_libros(id_miembro, id_libro, id_empleado, fecha_prestamo, fecha_entrega)" +
                    "values({0},{1},{2},'{3}','{4}')", id_miembro, id_libro, id_empleado, fecha_prestamo, fecha_entrega), cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cn.Close();
            }
            return salida;
        }

        public string RegistrarPrestamoComputadora
        (string id_miembro, string id_computadora, string id_empleado, string hora_entrada, string hora_salida)
        {
            string salida = "OK";
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("insert into PRESTAMO_COMPUTADORA (ID_MIEMC, ID_COMP,ID_EMP, HORA_ENTRADA, HORA_SALIDA)" +
                    "values({0},{1},{2},'{3}','{4}')", id_miembro, id_computadora, id_empleado, hora_entrada, hora_salida), cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cn.Close();
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
                cn.Close();
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
                if (!dr.IsClosed)
                {
                    dr.Close();
                }
                cn.Close();
            }
            return contador;
        }

        public string modificar_libro(string codigo, string nombre, string autor, string editorial, string edicion, string area,string perfilAutor, string perfil, string isbn, string cantidad, int año, string proveedor, string status, string id_autor)
        {
            //string fecha = date.Value.Date.ToShortDateString();
            string salida = "Registrado Exitosamente";
            if (id_autor == null)
            {
                id_autor = BuscarIDAutor(autor, area, perfilAutor);
            }
            try
            {
                cn.Open();
                cmd = new SqlCommand("update libros set nombre='" + nombre + "', id_autor='" + id_autor + "', editorial='" + editorial + "', edicion='" + edicion + "', perfil='" + perfil + "', isbn='" + isbn + "', cantidad='" + cantidad + "', año=" + año + ", proveedor='" + proveedor + "', status='"+status+"' where codigo='"+codigo+"'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se pudieron actualizar los datos: " + ex.ToString();
                cn.Close();
            }
            return salida;
        }

        public void llenarModificarLibro(TextBox txtCodigo, TextBox txtPerfilCodigo, TextBox txtTitulo, TextBox Autor, TextBox txtEditorial, TextBox txtEdicion, TextBox Area, TextBox txtPerfil, TextBox txtISBN, TextBox txtCantidad, TextBox txtAño, TextBox txtProveedor, ComboBox txtStatus, TextBox Fecha)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select libros.nombre as 'libros_nombre', libros.perfil as 'libros_perfil', autores.nombre as 'autores_nombre'," +
                    "editorial, edicion, area, autores.perfil as 'autores_perfil', isbn, cantidad, año, proveedor, status, fecha" +
                    " from libros inner join autores on libros.id_autor = autores.id_autors where codigo = "+txtCodigo.Text+" ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtTitulo.Text = dr["libros_nombre"].ToString();
                    txtPerfilCodigo.Text = dr["libros_perfil"].ToString();
                    Autor.Text = dr["autores_nombre"].ToString();
                    txtEditorial.Text = dr["editorial"].ToString();
                    txtEdicion.Text = dr["edicion"].ToString();
                    Area.Text = dr["area"].ToString();
                    txtPerfil.Text = dr["autores_perfil"].ToString();
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
                if (!dr.IsClosed)
                {
                    dr.Close();
                }
                cn.Close();
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
                cn.Close();
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
                if (!dr.IsClosed)
                {
                    dr.Close();
                }
                cn.Close();
            }
            return contador;
        }


        public DataSet ConsultarLibros(string nombre)
        {
            query = "select id_libro, codigo, isbn, autores.nombre as 'autor', libros.nombre, libros.perfil, cantidad, area, edicion  from libros  " +
                "INNER JOIN autores ON libros.id_autor = autores.id_autors where STATUS = 'ACTIVO'";
            if (nombre != "")
                query +="and nombre like '%" + nombre + "%'";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "LIBROS");
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
            return ds;
        }

        public DataSet ConsultarAutores(string Filtro)
        {
            query = "select id_autors, nombre, area, perfil from autores ";
            if (Filtro != "")
                query += "where nombre like '%" + Filtro + "%'";

            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "autores");
            return ds;
        }

        public DataSet ConsultarTiposMembresias() {
            query = "select tipo, precio from tipo_membresia ";

            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tipo_membresia");
            return ds;
        }

        public void llenarModificarMiembro(int id, string sexo, TextBox txtNombre, TextBox txtApellido, TextBox cbxTipo, TextBox txtTelefono, TextBox txtDireccion, TextBox txtCorreo, TextBox ocupacion, TextBox txtPago, TextBox txtStatus, RadioButton rdbMasculino, RadioButton rdbFemenino)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from membresia where id_miembro = " + id + " ", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
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
                if (sexo == "MASCULINO")
                    rdbMasculino.Checked = true;
                else
                    rdbFemenino.Checked = true;

                    dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (!dr.IsClosed)
                {
                    dr.Close();
                }
                cn.Close();
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
                cn.Close();
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
                cn.Close();
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }


        #region computadoras
        public string agergar_equipo(string tipo, string proveedor)
        {
            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into computadoras(tipo,proveedor)values('" + tipo + "','" + proveedor + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string modificar_equipo(string tipo, string proveedor, int id)
        {
            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update computadoras set tipo='" + tipo + "', proveedor='" + proveedor + "' where id_computadora = " + id + "", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public DataSet ConsultarEquipo(string filtro)
        {
            query = "select id_computadora , tipo, proveedor from COMPUTADORAS";
            if (filtro != "")
                query += " where tipo like '%" + filtro + "%' or id_Computadora like '%" + filtro + "%' or proveedor like '%"+filtro+"%'";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "COMPUTADORAS");
            return ds;
        }
        #endregion


        #region salas

        public string agergar_sala(int num_sala, int max_personas, string tipo_evento)
        {
            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into salas(num_sala, max_personas, tipo_eventos)values(" + num_sala + "," + max_personas + ",'" + tipo_evento + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string modificar_sala(int sala, int max_personas, string tipo_evento, int id)
        {
            string salida = "Registrado Exitosamente";
            try
            {
                cn.Open();
                cmd = new SqlCommand("update SALAS set NUM_SALA=" + sala + ", MAX_PERSONAS=" + max_personas + ", TIPO_EVENTOS ='" + tipo_evento +"' where id_salas = " + id + "", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public DataSet ConsultarSala(string nombre)
        {
            query = "select ID_SALAS, NUM_SALA, MAX_PERSONAS, TIPO_EVENTOS from SALAS";
            if (nombre != "")
                query += " where NUM_SALA like '%" + nombre + "%' or id_SALAS like '%" + nombre + "%'";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "SALAS");
            return ds;
        }
        #endregion

    }
}
