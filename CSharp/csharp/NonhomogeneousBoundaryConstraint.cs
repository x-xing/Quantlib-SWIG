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

public class NonhomogeneousBoundaryConstraint : Constraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NonhomogeneousBoundaryConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.NonhomogeneousBoundaryConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NonhomogeneousBoundaryConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NonhomogeneousBoundaryConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_NonhomogeneousBoundaryConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public NonhomogeneousBoundaryConstraint(QlArray l, QlArray u) : this(NQuantLibcPINVOKE.new_NonhomogeneousBoundaryConstraint(QlArray.getCPtr(l), QlArray.getCPtr(u)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}