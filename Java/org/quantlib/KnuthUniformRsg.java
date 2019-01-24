/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class KnuthUniformRsg {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected KnuthUniformRsg(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(KnuthUniformRsg obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_KnuthUniformRsg(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public KnuthUniformRsg(long dimensionality, KnuthUniformRng rng) {
    this(QuantLibJNI.new_KnuthUniformRsg(dimensionality, KnuthUniformRng.getCPtr(rng), rng), true);
  }

  public SampleRealVector nextSequence() {
    return new SampleRealVector(QuantLibJNI.KnuthUniformRsg_nextSequence(swigCPtr, this), false);
  }

  public long dimension() {
    return QuantLibJNI.KnuthUniformRsg_dimension(swigCPtr, this);
  }

}
