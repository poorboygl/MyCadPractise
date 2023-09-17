using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MyAutoCadAPI
{
    public class PlineRepository
    {
        public PlineRepository() { }
        public Polyline CreatePline(Transaction transaction, BlockTableRecord modelspace, List<Point2d> points)
        {
            Polyline pline = new Polyline();
            foreach (var point in points)
            {
                pline.AddVertexAt(pline.NumberOfVertices, point, 0, 0, 0);
            }

            pline.ColorIndex = 1; // Color is red
            modelspace.AppendEntity(pline);
            transaction.AddNewlyCreatedDBObject(pline, true);
            return pline;
        }
    }
}
