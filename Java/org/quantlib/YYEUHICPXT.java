/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class YYEUHICPXT extends YoYInflationIndex {
  private transient long swigCPtr;

  protected YYEUHICPXT(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.YYEUHICPXT_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(YYEUHICPXT obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_YYEUHICPXT(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public YYEUHICPXT(boolean interpolated, YoYInflationTermStructureHandle h) {
    this(QuantLibJNI.new_YYEUHICPXT__SWIG_0(interpolated, YoYInflationTermStructureHandle.getCPtr(h), h), true);
  }

  public YYEUHICPXT(boolean interpolated) {
    this(QuantLibJNI.new_YYEUHICPXT__SWIG_1(interpolated), true);
  }

}
