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

public class KrugerCubic : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KrugerCubic(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KrugerCubic obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KrugerCubic() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_KrugerCubic(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public KrugerCubic(QlArray x, QlArray y) : this(NQuantLibcPINVOKE.new_KrugerCubic(QlArray.getCPtr(x), QlArray.getCPtr(y)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double call(double x, bool allowExtrapolation) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_call__SWIG_0(swigCPtr, x, allowExtrapolation);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double call(double x) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_call__SWIG_1(swigCPtr, x);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double derivative(double x, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_derivative__SWIG_0(swigCPtr, x, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double derivative(double x) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_derivative__SWIG_1(swigCPtr, x);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double secondDerivative(double x, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_secondDerivative__SWIG_0(swigCPtr, x, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double secondDerivative(double x) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_secondDerivative__SWIG_1(swigCPtr, x);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double primitive(double x, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_primitive__SWIG_0(swigCPtr, x, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double primitive(double x) {
    double ret = NQuantLibcPINVOKE.KrugerCubic_primitive__SWIG_1(swigCPtr, x);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
