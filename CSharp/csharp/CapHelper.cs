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

public class CapHelper : CalibrationHelper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CapHelper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CapHelper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CapHelper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CapHelper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CapHelper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CapHelper(Period length, QuoteHandle volatility, IborIndex index, Frequency fixedLegFrequency, DayCounter fixedLegDayCounter, bool includeFirstSwaplet, YieldTermStructureHandle termStructure, _CalibrationHelper.CalibrationErrorType errorType) : this(NQuantLibcPINVOKE.new_CapHelper__SWIG_0(Period.getCPtr(length), QuoteHandle.getCPtr(volatility), IborIndex.getCPtr(index), (int)fixedLegFrequency, DayCounter.getCPtr(fixedLegDayCounter), includeFirstSwaplet, YieldTermStructureHandle.getCPtr(termStructure), (int)errorType), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapHelper(Period length, QuoteHandle volatility, IborIndex index, Frequency fixedLegFrequency, DayCounter fixedLegDayCounter, bool includeFirstSwaplet, YieldTermStructureHandle termStructure) : this(NQuantLibcPINVOKE.new_CapHelper__SWIG_1(Period.getCPtr(length), QuoteHandle.getCPtr(volatility), IborIndex.getCPtr(index), (int)fixedLegFrequency, DayCounter.getCPtr(fixedLegDayCounter), includeFirstSwaplet, YieldTermStructureHandle.getCPtr(termStructure)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.CapHelper_times(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
