using StorageAppWeb.Context;
using StorageAppWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace StorageAppWeb.Services
{
    public class DBService
    {
        public List<Room> getRooms()
        {
            EFContext efc = new EFContext();

            return efc.Rooms.ToList();

        }
    }
}
