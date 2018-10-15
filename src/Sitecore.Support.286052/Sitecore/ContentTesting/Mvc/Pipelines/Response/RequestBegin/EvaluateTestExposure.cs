using Sitecore.ContentTesting;
using Sitecore.ContentTesting.Data;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Pipelines.Request.RequestBegin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ContentTesting.Mvc.Pipelines.Response.RequestBegin
{
  public class EvaluateTestExposure: global::Sitecore.ContentTesting.Mvc.Pipelines.Response.RequestBegin.EvaluateTestExposure
  {
    public EvaluateTestExposure()
    {

    }

    public EvaluateTestExposure(IContentTestStore contentTestStore, IContentTestingFactory factory):base(contentTestStore,factory)
    {

    }

    public new void Process(RequestBeginArgs args)
    {
      try
      {
        base.Process(args);
      }
      catch(global::Sitecore.Analytics.DataAccess.XdbUnavailableException ex)
      {
        Log.Error("Failed to evaluate test exposure.", ex, this);
      }
    }
  }
}