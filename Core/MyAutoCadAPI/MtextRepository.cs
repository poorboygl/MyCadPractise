using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using static System.Net.Mime.MediaTypeNames;

namespace Core.MyAutoCadAPI
{
    public class MtextRepository
    {
        public MtextRepository() { }
        public MText CreateMtext(Transaction transaction, BlockTableRecord modelspace, Point3d originPoint, string content)
        {
            MText mtext = new MText();
            mtext.Contents = content;
            mtext.Location = originPoint;
            mtext.Height = 30;
            mtext.ColorIndex = 1;

            modelspace.AppendEntity(mtext);
            transaction.AddNewlyCreatedDBObject(mtext, true);
            return mtext;
        }
    }
}
