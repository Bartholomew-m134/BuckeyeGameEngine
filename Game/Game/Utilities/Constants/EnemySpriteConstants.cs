using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class EnemySpriteConstants
    {
        public const int TOTALGOOMBAWALKINGFRAMES = 4;
        public const int TOTALKOOPAEMERGINGFRAMES = 2;
        public const int TOTALKOOPAWALKINGFRAMES = 4;
        public const int RESETTOZERO = 0;
        public static readonly Vector2 GOOMBAFLIPPEDSOURCE = new Vector2(0,4);
        public static readonly Vector2 GOOMBAFLIPPEDDIMENSIONS = new Vector2(16,16);
        public static readonly Vector2 GOOMBASMASHEDSOURCE = new Vector2(60,8);
        public static readonly Vector2 GOOMBASMASHEDDIMENSIONS = new Vector2(16, 8);
        public static readonly Vector2 GOOMBAWALKINGLEFTDIMENSIONS = new Vector2(16, 16);
        public static readonly Vector2 FIRSTGOOMBAWALKINGLEFTSOURCE= new Vector2(0,4);
        public static readonly Vector2 SECONDGOOMBAWALKINGLEFTSOURCE= new Vector2(30,4);
        public static readonly Vector2[] GOOMBAWALKINGLEFTFRAMES = new Vector2[4] {FIRSTGOOMBAWALKINGLEFTSOURCE, 
            FIRSTGOOMBAWALKINGLEFTSOURCE, SECONDGOOMBAWALKINGLEFTSOURCE, SECONDGOOMBAWALKINGLEFTSOURCE };
        public static readonly Vector2 GOOMBAWALKINGRIGHTDIMENSIONS = new Vector2(16, 16);
        public static readonly Vector2 FIRSTGOOMBAWALKINGRIGHTSOURCE = new Vector2(0, 4);
        public static readonly Vector2 SECONDGOOMBAWALKINGRIGHTSOURCE = new Vector2(30, 4);
        public static readonly Vector2[] GOOMBAWALKINGRIGHTFRAMES = new Vector2[4] {FIRSTGOOMBAWALKINGRIGHTSOURCE, 
            FIRSTGOOMBAWALKINGRIGHTSOURCE, SECONDGOOMBAWALKINGRIGHTSOURCE, SECONDGOOMBAWALKINGRIGHTSOURCE };

        public static readonly Vector2 FIRSTKOOPAEMERGINGSOURCE = new Vector2(361,5);
        public static readonly Vector2 SECONDKOOPAEMERGINGSOURCE = new Vector2(331,4);
        public static readonly Vector2 FIRSTKOOPAEMERGINGDIMENSIONS = new Vector2(14,13);
        public static readonly Vector2 SECONDKOOPAEMERGINGDIMENSIONS = new Vector2(14,15);
        public static readonly Vector2[] KOOPAEMERGINGFRAMES = new Vector2[2] { FIRSTKOOPAEMERGINGSOURCE,
            SECONDKOOPAEMERGINGSOURCE };
        public static readonly Vector2[] KOOPAEMERGINGDIMENSIONS= new Vector2[2] { FIRSTKOOPAEMERGINGDIMENSIONS,SECONDKOOPAEMERGINGDIMENSIONS };

        public static readonly Vector2 KOOPAFLIPPEDSOURCE = new Vector2(361,5);
        public static readonly Vector2 KOOPAFLIPPEDDIMENSIONS = new Vector2(14,13);
        public static readonly Vector2 KOOPAHIDINGSOURCE = new Vector2(361, 5);
        public static readonly Vector2 KOOPAHIDINGDIMENSIONS = new Vector2(14, 13);
        public static readonly Vector2 FIRSTKOOPAWALKINGLEFTSOURCE = new Vector2(180,2);
        public static readonly Vector2 SECONDKOOPAWALKINGLEFTSOURCE = new Vector2(150, 2);
        public static readonly Vector2 FIRSTKOOPAWALKINGLEFTDIMENSIONS = new Vector2(16, 21);
        public static readonly Vector2 SECONDKOOPAWALKINGLEFTDIMENSIONS = new Vector2(15, 22);
        public static readonly Vector2[] KOOPAWALKINGLEFTSOURCES = new Vector2[4] { FIRSTKOOPAWALKINGLEFTSOURCE, 
            FIRSTKOOPAWALKINGLEFTSOURCE, SECONDKOOPAWALKINGLEFTSOURCE, SECONDKOOPAWALKINGLEFTSOURCE };
        public static readonly Vector2[] KOOPAWALKINGLEFTDIMENSIONS = new Vector2[4] { FIRSTKOOPAWALKINGLEFTDIMENSIONS, 
            FIRSTKOOPAWALKINGLEFTDIMENSIONS, SECONDKOOPAWALKINGLEFTDIMENSIONS, SECONDKOOPAWALKINGLEFTDIMENSIONS };
        public static readonly Vector2 FIRSTKOOPAWALKINGRIGHTSOURCE = new Vector2(210, 2);
        public static readonly Vector2 SECONDKOOPAWALKINGRIGHTSOURCE = new Vector2(241, 2);
        public static readonly Vector2 FIRSTKOOPAWALKINGRIGHTDIMENSIONS = new Vector2(16, 21);
        public static readonly Vector2 SECONDKOOPAWALKINGRIGHTDIMENSIONS = new Vector2(15, 22);
        public static readonly Vector2[] KOOPAWALKINGRIGHTSOURCES = new Vector2[4] { FIRSTKOOPAWALKINGRIGHTSOURCE, 
            FIRSTKOOPAWALKINGRIGHTSOURCE, SECONDKOOPAWALKINGRIGHTSOURCE, SECONDKOOPAWALKINGRIGHTSOURCE };
        public static readonly Vector2[] KOOPAWALKINGRIGHTDIMENSIONS = new Vector2[4] { FIRSTKOOPAWALKINGRIGHTDIMENSIONS, 
            FIRSTKOOPAWALKINGRIGHTDIMENSIONS, SECONDKOOPAWALKINGRIGHTDIMENSIONS, SECONDKOOPAWALKINGRIGHTDIMENSIONS };
    }
}
