/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class Bkbm5M extends Bkbm {
  private transient long swigCPtr;

  protected Bkbm5M(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.Bkbm5M_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Bkbm5M obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_Bkbm5M(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public Bkbm5M(YieldTermStructureHandle h) {
    this(QuantLibJNI.new_Bkbm5M__SWIG_0(YieldTermStructureHandle.getCPtr(h), h), true);
  }

  public Bkbm5M() {
    this(QuantLibJNI.new_Bkbm5M__SWIG_1(), true);
  }

}
