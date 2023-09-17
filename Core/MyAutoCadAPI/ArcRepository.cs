using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MyAutoCadAPI
{
    public class ArcRepository
    {
        public ArcRepository() { }
        public Arc CreateCirleWithRadius(Transaction transaction, BlockTableRecord modelspace, Point3d originpoint, double radius, double startAngle, double endAngle)
        {
            Arc arc = new Arc(originpoint, radius, startAngle, endAngle);
            arc.ColorIndex = 1; // Color is red
            modelspace.AppendEntity(arc);
            transaction.AddNewlyCreatedDBObject(arc, true);
            return arc;
        }
    }
}
