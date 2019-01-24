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

public class RelinkableCalibratedModelHandle : CalibratedModelHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RelinkableCalibratedModelHandle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RelinkableCalibratedModelHandle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableCalibratedModelHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableCalibratedModelHandle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableCalibratedModelHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RelinkableCalibratedModelHandle(CalibratedModel arg0) : this(NQuantLibcPINVOKE.new_RelinkableCalibratedModelHandle__SWIG_0(CalibratedModel.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableCalibratedModelHandle() : this(NQuantLibcPINVOKE.new_RelinkableCalibratedModelHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void linkTo(CalibratedModel arg0) {
    NQuantLibcPINVOKE.RelinkableCalibratedModelHandle_linkTo(swigCPtr, CalibratedModel.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
