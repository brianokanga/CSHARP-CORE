using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //1. Access YouTube web service
                //2. Read the data
                //3. create a list of Video objects

                //simulate an exception
                throw new Exception("Ooops some low level Youtube error");
            }
            catch (Exception ex)
            {
                //Log youTube Exceptions


                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}