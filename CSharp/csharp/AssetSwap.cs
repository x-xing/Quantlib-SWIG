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

public class AssetSwap : Swap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AssetSwap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.AssetSwap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AssetSwap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AssetSwap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_AssetSwap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AssetSwap(bool payFixedRate, Bond bond, double bondCleanPrice, InterestRateIndex index, double spread, Schedule floatSchedule, DayCounter floatingDayCount, bool parAssetSwap) : this(NQuantLibcPINVOKE.new_AssetSwap__SWIG_0(payFixedRate, Bond.getCPtr(bond), bondCleanPrice, InterestRateIndex.getCPtr(index), spread, Schedule.getCPtr(floatSchedule), DayCounter.getCPtr(floatingDayCount), parAssetSwap), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public AssetSwap(bool payFixedRate, Bond bond, double bondCleanPrice, InterestRateIndex index, double spread, Schedule floatSchedule, DayCounter floatingDayCount) : this(NQuantLibcPINVOKE.new_AssetSwap__SWIG_1(payFixedRate, Bond.getCPtr(bond), bondCleanPrice, InterestRateIndex.getCPtr(index), spread, Schedule.getCPtr(floatSchedule), DayCounter.getCPtr(floatingDayCount)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public AssetSwap(bool payFixedRate, Bond bond, double bondCleanPrice, InterestRateIndex index, double spread, Schedule floatSchedule) : this(NQuantLibcPINVOKE.new_AssetSwap__SWIG_2(payFixedRate, Bond.getCPtr(bond), bondCleanPrice, InterestRateIndex.getCPtr(index), spread, Schedule.getCPtr(floatSchedule)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public AssetSwap(bool payFixedRate, Bond bond, double bondCleanPrice, InterestRateIndex index, double spread) : this(NQuantLibcPINVOKE.new_AssetSwap__SWIG_3(payFixedRate, Bond.getCPtr(bond), bondCleanPrice, InterestRateIndex.getCPtr(index), spread), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double fairCleanPrice() {
    double ret = NQuantLibcPINVOKE.AssetSwap_fairCleanPrice(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairSpread() {
    double ret = NQuantLibcPINVOKE.AssetSwap_fairSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
