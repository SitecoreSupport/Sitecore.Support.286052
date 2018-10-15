using Sitecore.ContentTesting;
using Sitecore.ContentTesting.Data;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.RenderLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ContentTesting.Pipelines.RenderLayout
{
  public class EvaluateTestExposure: global::Sitecore.ContentTesting.Pipelines.RenderLayout.EvaluateTestExposure
  {
    public EvaluateTestExposure()
    {

    }

    public EvaluateTestExposure(IContentTestStore contentTestStore, IContentTestingFactory factory) : base(contentTestStore, factory)
    {

    }

    public new void Process(RenderLayoutArgs args)
    {
      try
      {
        base.Process(args);
      }
      catch (global::Sitecore.Analytics.DataAccess.XdbUnavailableException ex)
      {
        Log.Error("Failed to evaluate test exposure.", ex, this);
      }
    }
  }
}