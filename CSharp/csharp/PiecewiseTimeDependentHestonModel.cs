//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class PiecewiseTimeDependentHestonModel : CalibratedModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PiecewiseTimeDependentHestonModel(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PiecewiseTimeDependentHestonModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PiecewiseTimeDependentHestonModel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_PiecewiseTimeDependentHestonModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PiecewiseTimeDependentHestonModel(YieldTermStructureHandle riskFreeRate, YieldTermStructureHandle dividendYield, QuoteHandle s0, double v0, Parameter theta, Parameter kappa, Parameter sigma, Parameter rho, TimeGrid timeGrid) : this(NQuantLibcPINVOKE.new_PiecewiseTimeDependentHestonModel(YieldTermStructureHandle.getCPtr(riskFreeRate), YieldTermStructureHandle.getCPtr(dividendYield), QuoteHandle.getCPtr(s0), v0, Parameter.getCPtr(theta), Parameter.getCPtr(kappa), Parameter.getCPtr(sigma), Parameter.getCPtr(rho), TimeGrid.getCPtr(timeGrid)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double theta(double t) {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_theta(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double kappa(double t) {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_kappa(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double sigma(double t) {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_sigma(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double rho(double t) {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_rho(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double v0() {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_v0(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double s0() {
    double ret = NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_s0(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TimeGrid timeGrid() {
    TimeGrid ret = new TimeGrid(NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_timeGrid(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YieldTermStructureHandle dividendYield() {
    YieldTermStructureHandle ret = new YieldTermStructureHandle(NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_dividendYield(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YieldTermStructureHandle riskFreeRate() {
    YieldTermStructureHandle ret = new YieldTermStructureHandle(NQuantLibcPINVOKE.PiecewiseTimeDependentHestonModel_riskFreeRate(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
