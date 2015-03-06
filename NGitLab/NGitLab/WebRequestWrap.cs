using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NGitLab;
using NGitLab.Impl;

namespace NGitLab
{
    public interface IWebRequestWrap
    {
        WebRequest WRequest { get; set; }
        IWebResponseWrap Response { get; set; }
        IWebResponseWrap GetResponse();
        void AddHeader(string key, string value);
        void Create(Uri uri);
        void SetMethod(MethodType t);
    }

    public class WebRequestWrap : IWebRequestWrap
    {
         public WebRequest WRequest { get; set; }
         public IWebResponseWrap Response { get; set; }

        public WebRequestWrap(IWebResponseWrap wrap)
        {
            Response = wrap;
        }

        public void AddHeader(string key, string value)
        {
            WRequest.Headers[key] = value;
        }

        public void Create(Uri uri)
        {
           WRequest = WebRequest.Create(uri);   
        }

        public void SetMethod(MethodType t)
        {
            WRequest.Method = t.ToString().ToUpperInvariant();
        }

         public IWebResponseWrap GetResponse()
         {
             var r = WRequest.GetResponse();
             Response.Setup(r);
             return Response;

         }

      }

    public interface IWebResponseWrap:IDisposable
    {

        WebResponse RealResp { get; set; }
        void Setup(WebResponse resp);

        //long ContentLength { get; set; }
       // string ContentType { get; set; }
        WebHeaderCollection Headers { get; }
        //bool IsFromCache { get; }
        //bool IsMutuallyAuthenticated { get; }
        Uri ResponseUri { get;  }
        //bool SupportsHeaders { get; }
        void Close();
        void Dispose();
        //void Dispose(bool disposing);
        //void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
        Stream GetResponseStream();
    
    }

    public class WebResponseWrap : IWebResponseWrap
    {
        //needs to get set for everything else to work
        public WebResponse RealResp { get; set; }

        public WebHeaderCollection Headers { get; private set; }
        public Uri ResponseUri { get; private set; }
        public bool SupportsHeaders { get; private set; }

        public void Setup(WebResponse resp)
        {
            RealResp = resp;
            ResponseUri = resp.ResponseUri;
            SupportsHeaders = resp.SupportsHeaders;
            Headers = resp.Headers;
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }

        public virtual Stream GetResponseStream()
        {
            return RealResp.GetResponseStream();
        }


    }
}
