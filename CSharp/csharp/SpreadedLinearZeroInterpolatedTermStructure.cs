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

public class SpreadedLinearZeroInterpolatedTermStructure : YieldTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SpreadedLinearZeroInterpolatedTermStructure(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SpreadedLinearZeroInterpolatedTermStructure_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SpreadedLinearZeroInterpolatedTermStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SpreadedLinearZeroInterpolatedTermStructure() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SpreadedLinearZeroInterpolatedTermStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SpreadedLinearZeroInterpolatedTermStructure(YieldTermStructureHandle curveHandle, QuoteHandleVector spreadHandles, DateVector dates, Compounding comp, Frequency freq, DayCounter dc, Linear factory) : this(NQuantLibcPINVOKE.new_SpreadedLinearZeroInterpolatedTermStructure__SWIG_0(YieldTermStructureHandle.getCPtr(curveHandle), QuoteHandleVector.getCPtr(spreadHandles), DateVector.getCPtr(dates), (int)comp, (int)freq, DayCounter.getCPtr(dc), Linear.getCPtr(factory)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SpreadedLinearZeroInterpolatedTermStructure(YieldTermStructureHandle curveHandle, QuoteHandleVector spreadHandles, DateVector dates, Compounding comp, Frequency freq, DayCounter dc) : this(NQuantLibcPINVOKE.new_SpreadedLinearZeroInterpolatedTermStructure__SWIG_1(YieldTermStructureHandle.getCPtr(curveHandle), QuoteHandleVector.getCPtr(spreadHandles), DateVector.getCPtr(dates), (int)comp, (int)freq, DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SpreadedLinearZeroInterpolatedTermStructure(YieldTermStructureHandle curveHandle, QuoteHandleVector spreadHandles, DateVector dates, Compounding comp, Frequency freq) : this(NQuantLibcPINVOKE.new_SpreadedLinearZeroInterpolatedTermStructure__SWIG_2(YieldTermStructureHandle.getCPtr(curveHandle), QuoteHandleVector.getCPtr(spreadHandles), DateVector.getCPtr(dates), (int)comp, (int)freq), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SpreadedLinearZeroInterpolatedTermStructure(YieldTermStructureHandle curveHandle, QuoteHandleVector spreadHandles, DateVector dates, Compounding comp) : this(NQuantLibcPINVOKE.new_SpreadedLinearZeroInterpolatedTermStructure__SWIG_3(YieldTermStructureHandle.getCPtr(curveHandle), QuoteHandleVector.getCPtr(spreadHandles), DateVector.getCPtr(dates), (int)comp), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SpreadedLinearZeroInterpolatedTermStructure(YieldTermStructureHandle curveHandle, QuoteHandleVector spreadHandles, DateVector dates) : this(NQuantLibcPINVOKE.new_SpreadedLinearZeroInterpolatedTermStructure__SWIG_4(YieldTermStructureHandle.getCPtr(curveHandle), QuoteHandleVector.getCPtr(spreadHandles), DateVector.getCPtr(dates)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
