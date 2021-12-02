using BojkoSoft.Transformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BojkoSoft.Transformations.Constants;

namespace TransformGeo.Controllers
{
   // [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public double[] Get(int i, double x,double y)
        {
            Transformations tr = new Transformations();

            GeoPoint input = new GeoPoint(x, y);
            GeoPoint result = new GeoPoint();

            if (i == 5)
            {
                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_1970_K5, enumProjection.BGS_2005_KK);
            }
       else if (i == 7)
            {

                  result = tr.TransformBGSCoordinates(input, enumProjection.BGS_1970_K7, enumProjection.BGS_2005_KK);
                
            }
            else if (i==9)
            {
                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_1970_K9, enumProjection.BGS_2005_KK);
            }

            else if (i == 3)
            {
                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_1970_K3, enumProjection.BGS_2005_KK);
            }


      
           else if (i == 55)
            {

             result =  tr.TransformBGSCoordinates(input, enumProjection.BGS_2005_KK, enumProjection.BGS_1970_K5);
                

            }

            else if (i == 77)
            {

                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_2005_KK, enumProjection.BGS_1970_K7);

            }

            else if (i == 99)
            {

                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_2005_KK, enumProjection.BGS_1970_K9);

            }
            else if (i == 33)
            {

                result = tr.TransformBGSCoordinates(input, enumProjection.BGS_2005_KK, enumProjection.BGS_1970_K3);

            }
            else
            {
                double[] ret = { 1.111, 1.111 };
                return ret;
            }
            double[] coordinates = { result.X, result.Y };
            return coordinates;








        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
