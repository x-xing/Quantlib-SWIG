/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class YYUSCPI extends YoYInflationIndex {
  private transient long swigCPtr;

  protected YYUSCPI(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.YYUSCPI_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(YYUSCPI obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_YYUSCPI(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public YYUSCPI(boolean interpolated, YoYInflationTermStructureHandle h) {
    this(QuantLibJNI.new_YYUSCPI__SWIG_0(interpolated, YoYInflationTermStructureHandle.getCPtr(h), h), true);
  }

  public YYUSCPI(boolean interpolated) {
    this(QuantLibJNI.new_YYUSCPI__SWIG_1(interpolated), true);
  }

}
