/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class Euribor5M extends Euribor {
  private transient long swigCPtr;

  protected Euribor5M(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.Euribor5M_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Euribor5M obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_Euribor5M(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public Euribor5M(YieldTermStructureHandle h) {
    this(QuantLibJNI.new_Euribor5M__SWIG_0(YieldTermStructureHandle.getCPtr(h), h), true);
  }

  public Euribor5M() {
    this(QuantLibJNI.new_Euribor5M__SWIG_1(), true);
  }

}
