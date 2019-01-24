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

public class ChfLiborSwapIsdaFix : SwapIndex {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChfLiborSwapIsdaFix(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.ChfLiborSwapIsdaFix_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChfLiborSwapIsdaFix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChfLiborSwapIsdaFix() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_ChfLiborSwapIsdaFix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ChfLiborSwapIsdaFix(Period tenor, YieldTermStructureHandle h) : this(NQuantLibcPINVOKE.new_ChfLiborSwapIsdaFix__SWIG_0(Period.getCPtr(tenor), YieldTermStructureHandle.getCPtr(h)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChfLiborSwapIsdaFix(Period tenor) : this(NQuantLibcPINVOKE.new_ChfLiborSwapIsdaFix__SWIG_1(Period.getCPtr(tenor)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChfLiborSwapIsdaFix(Period tenor, YieldTermStructureHandle h1, YieldTermStructureHandle h2) : this(NQuantLibcPINVOKE.new_ChfLiborSwapIsdaFix__SWIG_2(Period.getCPtr(tenor), YieldTermStructureHandle.getCPtr(h1), YieldTermStructureHandle.getCPtr(h2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
