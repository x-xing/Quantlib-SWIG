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

public class CappedFlooredCoupon : FloatingRateCoupon {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CappedFlooredCoupon(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CappedFlooredCoupon_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CappedFlooredCoupon obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CappedFlooredCoupon() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CappedFlooredCoupon(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CappedFlooredCoupon(FloatingRateCoupon underlying, double cap, double floor) : this(NQuantLibcPINVOKE.new_CappedFlooredCoupon__SWIG_0(FloatingRateCoupon.getCPtr(underlying), cap, floor), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CappedFlooredCoupon(FloatingRateCoupon underlying, double cap) : this(NQuantLibcPINVOKE.new_CappedFlooredCoupon__SWIG_1(FloatingRateCoupon.getCPtr(underlying), cap), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CappedFlooredCoupon(FloatingRateCoupon underlying) : this(NQuantLibcPINVOKE.new_CappedFlooredCoupon__SWIG_2(FloatingRateCoupon.getCPtr(underlying)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double cap() {
    double ret = NQuantLibcPINVOKE.CappedFlooredCoupon_cap(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double floor() {
    double ret = NQuantLibcPINVOKE.CappedFlooredCoupon_floor(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double effectiveCap() {
    double ret = NQuantLibcPINVOKE.CappedFlooredCoupon_effectiveCap(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double effectiveFloor() {
    double ret = NQuantLibcPINVOKE.CappedFlooredCoupon_effectiveFloor(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isCapped() {
    bool ret = NQuantLibcPINVOKE.CappedFlooredCoupon_isCapped(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isFloored() {
    bool ret = NQuantLibcPINVOKE.CappedFlooredCoupon_isFloored(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new void setPricer(FloatingRateCouponPricer p) {
    NQuantLibcPINVOKE.CappedFlooredCoupon_setPricer(swigCPtr, FloatingRateCouponPricer.getCPtr(p));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
