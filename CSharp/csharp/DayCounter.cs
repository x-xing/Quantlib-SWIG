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

public class DayCounter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DayCounter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DayCounter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DayCounter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DayCounter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int dayCount(Date d1, Date d2) {
    int ret = NQuantLibcPINVOKE.DayCounter_dayCount(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double yearFraction(Date d1, Date d2, Date startRef, Date endRef) {
    double ret = NQuantLibcPINVOKE.DayCounter_yearFraction__SWIG_0(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(startRef), Date.getCPtr(endRef));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double yearFraction(Date d1, Date d2, Date startRef) {
    double ret = NQuantLibcPINVOKE.DayCounter_yearFraction__SWIG_1(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(startRef));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double yearFraction(Date d1, Date d2) {
    double ret = NQuantLibcPINVOKE.DayCounter_yearFraction__SWIG_2(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = NQuantLibcPINVOKE.DayCounter_name(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string __str__() {
    string ret = NQuantLibcPINVOKE.DayCounter___str__(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
