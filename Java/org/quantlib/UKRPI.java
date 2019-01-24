/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class UKRPI extends ZeroInflationIndex {
  private transient long swigCPtr;

  protected UKRPI(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.UKRPI_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(UKRPI obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_UKRPI(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public UKRPI(boolean interpolated, ZeroInflationTermStructureHandle h) {
    this(QuantLibJNI.new_UKRPI__SWIG_0(interpolated, ZeroInflationTermStructureHandle.getCPtr(h), h), true);
  }

  public UKRPI(boolean interpolated) {
    this(QuantLibJNI.new_UKRPI__SWIG_1(interpolated), true);
  }

}