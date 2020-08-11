using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CabinTypeBUS
    {
        public CabinTypeBUS() { }

        private CabinTypeDAO cabinTypeDAO = new CabinTypeDAO();
        public CabinTypeDTO GetCabinTypeByID(string cabinTypeID)
        {
            DataTable dt = cabinTypeDAO.GetCabinTypeTableByID(cabinTypeID);
            DataRow dr = dt.Rows[0];
            CabinTypeDTO cabinType = new CabinTypeDTO();

            cabinType.ID = int.Parse(dr[0].ToString());
            cabinType.Name = dr[1].ToString();

            return cabinType;
        }
    }
}
