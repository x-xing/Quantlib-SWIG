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

public class BrownianBridge : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BrownianBridge(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BrownianBridge obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BrownianBridge() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BrownianBridge(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BrownianBridge(uint steps) : this(NQuantLibcPINVOKE.new_BrownianBridge__SWIG_0(steps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BrownianBridge(DoubleVector times) : this(NQuantLibcPINVOKE.new_BrownianBridge__SWIG_1(DoubleVector.getCPtr(times)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BrownianBridge(TimeGrid timeGrid) : this(NQuantLibcPINVOKE.new_BrownianBridge__SWIG_2(TimeGrid.getCPtr(timeGrid)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = NQuantLibcPINVOKE.BrownianBridge_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.BrownianBridge_times(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector leftWeight() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.BrownianBridge_leftWeight(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector rightWeight() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.BrownianBridge_rightWeight(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector stdDeviation() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.BrownianBridge_stdDeviation(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector transform(DoubleVector input) {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.BrownianBridge_transform(swigCPtr, DoubleVector.getCPtr(input)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UnsignedIntVector bridgeIndex() {
    UnsignedIntVector ret = new UnsignedIntVector(NQuantLibcPINVOKE.BrownianBridge_bridgeIndex(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UnsignedIntVector leftIndex() {
    UnsignedIntVector ret = new UnsignedIntVector(NQuantLibcPINVOKE.BrownianBridge_leftIndex(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UnsignedIntVector rightIndex() {
    UnsignedIntVector ret = new UnsignedIntVector(NQuantLibcPINVOKE.BrownianBridge_rightIndex(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
