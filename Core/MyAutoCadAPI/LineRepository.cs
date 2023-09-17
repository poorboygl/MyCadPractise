using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Core.MyAutoCadAPI
{
    public class LineRepository
    {
        public LineRepository() { }
        public Line CreateLine3d(Transaction transaction, BlockTableRecord modelspace, Point3d startpoint,  Point3d endpoint)
        {
            Line line = new Line(startpoint, endpoint);

            line.ColorIndex = 1; // Color is red
            modelspace.AppendEntity(line);
            transaction.AddNewlyCreatedDBObject(line, true);
            return line;
        }

    }
}
