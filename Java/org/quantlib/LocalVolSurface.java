/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class LocalVolSurface extends LocalVolTermStructure {
  private transient long swigCPtr;

  protected LocalVolSurface(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.LocalVolSurface_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(LocalVolSurface obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_LocalVolSurface(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public LocalVolSurface(BlackVolTermStructureHandle blackTS, YieldTermStructureHandle riskFreeTS, YieldTermStructureHandle dividendTS, QuoteHandle underlying) {
    this(QuantLibJNI.new_LocalVolSurface__SWIG_0(BlackVolTermStructureHandle.getCPtr(blackTS), blackTS, YieldTermStructureHandle.getCPtr(riskFreeTS), riskFreeTS, YieldTermStructureHandle.getCPtr(dividendTS), dividendTS, QuoteHandle.getCPtr(underlying), underlying), true);
  }

  public LocalVolSurface(BlackVolTermStructureHandle blackTS, YieldTermStructureHandle riskFreeTS, YieldTermStructureHandle dividendTS, double underlying) {
    this(QuantLibJNI.new_LocalVolSurface__SWIG_1(BlackVolTermStructureHandle.getCPtr(blackTS), blackTS, YieldTermStructureHandle.getCPtr(riskFreeTS), riskFreeTS, YieldTermStructureHandle.getCPtr(dividendTS), dividendTS, underlying), true);
  }

}