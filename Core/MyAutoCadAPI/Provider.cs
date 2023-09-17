using Autodesk.AutoCAD.GraphicsSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MyAutoCadAPI
{
    public class Provider
    {
        public Provider()
        {          
        }
        PlineRepository plinerepository;
        public PlineRepository PlineRepository
        {
            get
            {
                if (plinerepository is null)
                {
                    plinerepository = new PlineRepository();
                }
                return plinerepository;
            }
        }
        ArcRepository arcrepository;
        public ArcRepository ArcRepository
        {
            get
            {
                if (arcrepository is null)
                {
                    arcrepository = new ArcRepository();
                }
                return arcrepository;
            }
        }

        CircleRepository circlerepository;
        public CircleRepository CircleRepository
        {
            get
            {
                if (circlerepository is null)
                {
                    circlerepository = new CircleRepository();
                }
                return circlerepository;
            }
        }

        LineRepository lineRepository;
        public LineRepository LineRepository
        {
            get
            {
                if (lineRepository is null)
                {
                    lineRepository = new LineRepository();
                }
                return lineRepository;
            }
        }

        MtextRepository mtextRepository;
        public MtextRepository MtextRepository
        {
            get
            {
                if (mtextRepository is null)
                {
                    mtextRepository = new MtextRepository();
                }
                return mtextRepository;
            }
        }

    }
}
