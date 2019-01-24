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

public class RelinkableYieldTermStructureHandle : YieldTermStructureHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RelinkableYieldTermStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RelinkableYieldTermStructureHandle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableYieldTermStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableYieldTermStructureHandle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableYieldTermStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RelinkableYieldTermStructureHandle(YieldTermStructure arg0) : this(NQuantLibcPINVOKE.new_RelinkableYieldTermStructureHandle__SWIG_0(YieldTermStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableYieldTermStructureHandle() : this(NQuantLibcPINVOKE.new_RelinkableYieldTermStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void linkTo(YieldTermStructure arg0) {
    NQuantLibcPINVOKE.RelinkableYieldTermStructureHandle_linkTo(swigCPtr, YieldTermStructure.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}