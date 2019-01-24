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

public class BachelierSwaptionEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BachelierSwaptionEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.BachelierSwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BachelierSwaptionEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BachelierSwaptionEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BachelierSwaptionEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BachelierSwaptionEngine(YieldTermStructureHandle discountCurve, QuoteHandle vol, DayCounter dc) : this(NQuantLibcPINVOKE.new_BachelierSwaptionEngine__SWIG_0(YieldTermStructureHandle.getCPtr(discountCurve), QuoteHandle.getCPtr(vol), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BachelierSwaptionEngine(YieldTermStructureHandle discountCurve, QuoteHandle vol) : this(NQuantLibcPINVOKE.new_BachelierSwaptionEngine__SWIG_1(YieldTermStructureHandle.getCPtr(discountCurve), QuoteHandle.getCPtr(vol)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BachelierSwaptionEngine(YieldTermStructureHandle discountCurve, SwaptionVolatilityStructureHandle v) : this(NQuantLibcPINVOKE.new_BachelierSwaptionEngine__SWIG_2(YieldTermStructureHandle.getCPtr(discountCurve), SwaptionVolatilityStructureHandle.getCPtr(v)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
