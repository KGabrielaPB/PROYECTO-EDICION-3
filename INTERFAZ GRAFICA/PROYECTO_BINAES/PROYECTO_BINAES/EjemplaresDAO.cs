using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES
{
    public class EjemplaresDAO
    {
        public static bool ReservarLibro(int codigo, int carnet)
        {
            using (EFDB.PROYECTOv17Entities db = new EFDB.PROYECTOv17Entities())
            {
                var reserva = new EFDB.RESERVA() { carnet_usuario = carnet, codigo_ejemplar = codigo, f_h_reserva = DateTime.Now, f_h_devolucion = DateTime.Now.AddDays(3) };
                db.RESERVA.Add(reserva);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else return false;

            }

        }

        public static bool PrestarLibro(int codigo, int carnet)
        {
            using (EFDB.PROYECTOv17Entities db = new EFDB.PROYECTOv17Entities())
            {
                var prestamo = new EFDB.PRESTAMO() { carnet_usuario = carnet, codigo_ejemplar = codigo, f_h_prestamo = DateTime.Now, f_h_devolucion = DateTime.Now.AddDays(3) };
                db.PRESTAMO.Add(prestamo);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else return false;

            }

        }
    }
}
