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

public class RelinkableYoYInflationTermStructureHandle : YoYInflationTermStructureHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RelinkableYoYInflationTermStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RelinkableYoYInflationTermStructureHandle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableYoYInflationTermStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableYoYInflationTermStructureHandle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableYoYInflationTermStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RelinkableYoYInflationTermStructureHandle(YoYInflationTermStructure arg0) : this(NQuantLibcPINVOKE.new_RelinkableYoYInflationTermStructureHandle__SWIG_0(YoYInflationTermStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableYoYInflationTermStructureHandle() : this(NQuantLibcPINVOKE.new_RelinkableYoYInflationTermStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void linkTo(YoYInflationTermStructure arg0) {
    NQuantLibcPINVOKE.RelinkableYoYInflationTermStructureHandle_linkTo(swigCPtr, YoYInflationTermStructure.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
