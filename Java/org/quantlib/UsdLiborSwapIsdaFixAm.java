/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class UsdLiborSwapIsdaFixAm extends SwapIndex {
  private transient long swigCPtr;

  protected UsdLiborSwapIsdaFixAm(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.UsdLiborSwapIsdaFixAm_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(UsdLiborSwapIsdaFixAm obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_UsdLiborSwapIsdaFixAm(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public UsdLiborSwapIsdaFixAm(Period tenor, YieldTermStructureHandle h) {
    this(QuantLibJNI.new_UsdLiborSwapIsdaFixAm__SWIG_0(Period.getCPtr(tenor), tenor, YieldTermStructureHandle.getCPtr(h), h), true);
  }

  public UsdLiborSwapIsdaFixAm(Period tenor) {
    this(QuantLibJNI.new_UsdLiborSwapIsdaFixAm__SWIG_1(Period.getCPtr(tenor), tenor), true);
  }

  public UsdLiborSwapIsdaFixAm(Period tenor, YieldTermStructureHandle h1, YieldTermStructureHandle h2) {
    this(QuantLibJNI.new_UsdLiborSwapIsdaFixAm__SWIG_2(Period.getCPtr(tenor), tenor, YieldTermStructureHandle.getCPtr(h1), h1, YieldTermStructureHandle.getCPtr(h2), h2), true);
  }

}