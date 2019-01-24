/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class EURLiborSW extends EURLibor {
  private transient long swigCPtr;

  protected EURLiborSW(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.EURLiborSW_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(EURLiborSW obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_EURLiborSW(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public EURLiborSW(YieldTermStructureHandle h) {
    this(QuantLibJNI.new_EURLiborSW__SWIG_0(YieldTermStructureHandle.getCPtr(h), h), true);
  }

  public EURLiborSW() {
    this(QuantLibJNI.new_EURLiborSW__SWIG_1(), true);
  }

}