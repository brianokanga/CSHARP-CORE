using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder

    {
        //EVENT
        //1. Define a delegate
        //2. Define an event based on that delegate
        //3. Raise/Publish event

        //Custom Event delegate
        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        //public event VideoEncoderEventHandler VideoEncoded;

        //using inBuild eventHandlers
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video = video });
        }
    }
}