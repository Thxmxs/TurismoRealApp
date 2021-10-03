using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Reserva
    {
        public decimal idReserva { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        public String firmaConformidadCliente { get; set; }
        public String usuarioIdUsuario { get; set; }
        public Usuario usuario { get; set; }
        public Departamento departamento{ get; set; }


        TurismoRealEntities db = new TurismoRealEntities();//nme

        public List<Reserva> ReadAll()
        {
            return this.db.RESERVA.Select(p => new Reserva()
            {
                idReserva = p.ID_RESERVA,
                fechaEntrada = (DateTime)p.FECHA_ENTRADA,
                fechaSalida = (DateTime)p.FECHA_SALIDA,
                firmaConformidadCliente = p.FIRMA_CONFORMIDAD_CLIENTE,
                usuarioIdUsuario = p.USUARIO_ID_USUARIO,
                usuario = new Usuario()
                {
                    rutUsuario = p.USUARIO.RUT_USUARIO,
                    nombre = p.USUARIO.NOMBRE,
                    apellido = p.USUARIO.APELLIDO,
                    email = p.USUARIO.EMAIL,
                    direccion = p.USUARIO.DIRECCION,
                    telefono = p.USUARIO.TELEFONO,
                    idCuentaUsuario = p.USUARIO.CUENTA_USUARIO_ID_CUENTA_USUARIO
                },

            }).ToList();
        }
        public bool Save(int idDepartamento,String rutUser)
        {
            try
            {
                //llamar procedimiento almacenado
                db.SP_CREATE_RESERVA(this.fechaEntrada,this.fechaSalida,this.firmaConformidadCliente, rutUser, idDepartamento);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        
    }
}
