namespace PokemonFinalProjectNet6.Infrastructure.Constants
{


	public static class PokemonTypeChart
    {
        static float h = 0.5f;
        static float d = 2f;
        static float o = 0f;

        public static float[][] typeChart =
        {
            //                           NRM  FIR WAT GAR ELe ICE FIT POI GRD FLY PSY BUG ROC GHO DRA Dak Stl FRY
            /*Noraml*/       new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f,  h,  o,  1f, 1f, h, 1f },
            /*Fire*/         new float[] {1f, h,  h,  d,  1f, d,  1f, 1f, 1f, 1f, 1f, d,   h, 1f,  h,  1f, d, 1f },
            /*Water*/        new float[] {1f, d,  h,  h,  1f, 1f, 1f, 1f,  d, 1f, 1f, 1f,  d, 1f,  h,  1f, 1f,1f },
            /*Grass*/        new float[] {1f, h,  d,  h,  1f, 1f, 1f,  h,  d,  h, 1f, h,   d, 1f,  h,  1f,  h,1f },
            /*Electric*/     new float[] {1f, 1f, d,  h,   h, 1f, 1f, 1f,  o,  d, 1f, 1f, 1f, 1f,  h,  1f, 1f,1f },
            /*Ice*/          new float[] {1f,  h, h,  d,  1f, 1f, 1f, 1f,  d,  d, 1f, 1f, 1f, 1f,  d,  1f,  h,1f },
            /*Fighting*/     new float[] {d,  1f, 1f, 1f, 1f,  d, 1f,  h, 1f,  h,  h,  h,  d, 0f,  1f,  d,  d, h },
            /*Poison*/       new float[] {1f, 1f, 1f,  h, 1f, 1f, 1f,  h,  h, 1f, 1f, 1f,  h,  h, 1f,  1f,  o, d },
            /*Ground*/       new float[] {1f,  d, 1f,  h, 1f, 1f, 1f,  d, 1f,  o, 1f,  h, 1f, 1f, 1f,  1f,  d,1f },
            /*Flying*/       new float[] {1f, 1f, 1f,  d,  h, 1f,  d, 1f, 1f, 1f, 1f,  d,  h, 1f, 1f,  1f,  h,1f },
            /*Psychic*/      new float[] {1f, 1f, 1f, 1f, 1f, 1f,  d,  d, 1f, 1f,  h, 1f, 1f, 1f, 1f,   o,  h,1f },
            /*Bug*/          new float[] {1f,  h, 1f,  d, 1f, 1f,  h,  h, 1f,  h,  d, 1f,  h, 1f, 1f,   d,  h,1f },
            /*Rock*/         new float[] {1f,  d, 1f, 1f, 1f,  d,  h, 1f, 1f,  d, 1f,  d,  h, 1f, 1f,  1f,  h,1f },
            /*Ghost*/        new float[] { o, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f,  h, 1f,  d, 1f,   h, 1f,1f },
            /*Dragon*/       new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f,  d,  1f,  h, o },
            /*Dark  */       new float[] {1f, 1f, 1f, 1f, 1f, 1f,  h, 1f, 1f, 1f,  d, 1f, 1f,  d, 1f,   h, 1f, h },
            /*Steel */       new float[] {1f,  h,  h, 1f, 1f,  d, 1f, 1f, 1f, 1f, 1f, 1f,  d, 1f, 1f,  1f,  h, d },
            /*Fairy */       new float[] {1f,  h, 1f, 1f, 1f, 1f,  d,  h, 1f, 1f, 1f, 1f, 1f, 1f,  d,   d,  h,1f }
        }; 
    }
}
