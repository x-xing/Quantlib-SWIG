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

public class BlackVolTermStructure : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BlackVolTermStructure(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BlackVolTermStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlackVolTermStructure() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BlackVolTermStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_BlackVolTermStructure __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.BlackVolTermStructure___deref__(swigCPtr);
    SWIGTYPE_p_BlackVolTermStructure ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_BlackVolTermStructure(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.BlackVolTermStructure_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.BlackVolTermStructure_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BlackVolTermStructure() : this(NQuantLibcPINVOKE.new_BlackVolTermStructure(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Date referenceDate() {
    Date ret = new Date(NQuantLibcPINVOKE.BlackVolTermStructure_referenceDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.BlackVolTermStructure_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.BlackVolTermStructure_calendar(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date maxDate() {
    Date ret = new Date(NQuantLibcPINVOKE.BlackVolTermStructure_maxDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxTime() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_maxTime(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double minStrike() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_minStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxStrike() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_maxStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(Date arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVol__SWIG_0(swigCPtr, Date.getCPtr(arg0), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(Date arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVol__SWIG_1(swigCPtr, Date.getCPtr(arg0), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(double arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVol__SWIG_2(swigCPtr, arg0, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(double arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVol__SWIG_3(swigCPtr, arg0, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVariance__SWIG_0(swigCPtr, Date.getCPtr(arg0), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVariance__SWIG_1(swigCPtr, Date.getCPtr(arg0), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVariance__SWIG_2(swigCPtr, arg0, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackVariance__SWIG_3(swigCPtr, arg0, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(Date arg0, Date arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVol__SWIG_0(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(Date arg0, Date arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVol__SWIG_1(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(double arg0, double arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVol__SWIG_2(swigCPtr, arg0, arg1, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(double arg0, double arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVol__SWIG_3(swigCPtr, arg0, arg1, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(Date arg0, Date arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVariance__SWIG_0(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(Date arg0, Date arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVariance__SWIG_1(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(double arg0, double arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVariance__SWIG_2(swigCPtr, arg0, arg1, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(double arg0, double arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructure_blackForwardVariance__SWIG_3(swigCPtr, arg0, arg1, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableExtrapolation() {
    NQuantLibcPINVOKE.BlackVolTermStructure_enableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableExtrapolation() {
    NQuantLibcPINVOKE.BlackVolTermStructure_disableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool allowsExtrapolation() {
    bool ret = NQuantLibcPINVOKE.BlackVolTermStructure_allowsExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}