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

        public List<Storage> getStorages()
        {
            EFContext efc = new EFContext();

            return efc.Storages.ToList();

        }

        public List<Storage> getStoragesOfRoom(int roomid)
        {
            EFContext efc = new EFContext();

            List<Storage> result = new List<Storage>();

            foreach (var storage in efc.Storages.ToList())
            {
                if (storage.RoomId == roomid)
                {
                    result.Add(storage);
                }
            }

            //return efc.Storages.ToList();
            return result;

        }

        public dynamic getItems()
        {
            EFContext efc = new EFContext();

            var data = efc.Items.Join(
            efc.Storages,
            item => item.StorageId,
            storage => storage.Id,
            (item, storage) => new
            {
                StorageId = storage.Id,
                StorageName = storage.Name,
                ItemId = item.Id,
                ItemName = item.Name,
                Quantity = item.Quantity
            }

            ).ToList();

            return data;
        }
        public dynamic getItems(int roomid)
        {
            EFContext efc = new EFContext();

            var data = efc.Items.Join(
            efc.Storages,
            item => item.StorageId,
            storage => storage.Id,
            (item, storage) => new
            {
                StorageId = storage.Id,
                StorageName = storage.Name,
                RoomId = storage.RoomId,
                ItemId = item.Id,
                ItemName = item.Name,
                Quantity = item.Quantity
            }

            ).ToList();

            foreach (var value in data.ToList())
            {
                if (value.RoomId != roomid)
                {
                    data.Remove(value);
                }
            }

            return data;
        }
    }
}
