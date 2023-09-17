using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MyAutoCadAPI
{
    public class LayerRepository
    {
        public LayerRepository() { }

        public ArrayList GetLayers(Transaction transaction, Database db)
        {

            ArrayList layers = new ArrayList();
            LayerTable layerTable = transaction.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (var lt in layerTable)
                {
                    LayerTableRecord lytr = transaction.GetObject(lt, OpenMode.ForRead) as LayerTableRecord;
                    layers.Add(lytr.Name);
                }            
            return layers;
        }
    }
}
